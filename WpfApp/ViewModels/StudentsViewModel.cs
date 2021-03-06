﻿using DAL.Services;
using Models;
using Services.Client;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp.Commands;
using WpfApp.Views;

namespace WpfApp.ViewModels
{
    public class StudentsViewModel : PeopleViewModel<Student, ICrudService<Student>>
    {
        public override ICommand AddCommand => new CustomCommand(async obj => await AddOrEditAsync(new Student()), obj => true);

        protected override ICrudService<Student> Service { get; } = new PeopleService<Student>("Student");

        protected override Window CreateAddEditDialog(Student clone)
        {
            return new StudentDialog(clone);
        }
    }
}
