﻿using Prism.Commands;
using Prism.Navigation;
using System;

namespace TaskMobile.ViewModels.Tasks
{
    public class ExecutedViewModel : BaseViewModel, INavigatingAware
    {

        private int _TaskNumber;
        /// <summary>
        /// Executed task number.
        /// </summary>
        public int TaskNumber
        {
            get { return _TaskNumber; }
            set { SetProperty(ref _TaskNumber, value); }
        }

        private DelegateCommand _Other;
        public DelegateCommand OtherCommand =>
            _Other ?? (_Other = new DelegateCommand(ExecuteOtherCommand));

        private DelegateCommand _Finish;
        public DelegateCommand FinishCommand =>
            _Finish ?? (_Finish = new DelegateCommand(ExecuteFinishCommand));

        
       
        public ExecutedViewModel(INavigationService navigationService):base (navigationService)
        {
        }


        /// <summary>
        /// Navigate to <see cref="Views.Tasks.Assigned"/> view for continue working in assigned tasks.
        /// </summary>
        private async void  ExecuteOtherCommand()
        {
            await _navigationService.NavigateAsync("TaskMobile:///MainPage/NavigationPage/AssignedTasks");
        }

        /// <summary>
        /// Go to main page.
        /// </summary>
        private async void ExecuteFinishCommand()
        {
            await _navigationService.NavigateAsync("TaskMobile:///MainPage");
        }
        void INavigatingAware.OnNavigatingTo(NavigationParameters parameters)
        {
            Models.TaskDetail Executed = parameters["ExecutedTask"] as Models.TaskDetail;
            TaskNumber = Executed.TaskNumber;
        }
    }
}