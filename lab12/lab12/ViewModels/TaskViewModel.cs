using lab12.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace lab12.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }
        string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        string isCompleted;
        public string IsCompleted
        {
            get { return isCompleted; }
            set
            {
                if (isCompleted != value)
                {
                    isCompleted = value;
                    OnPropertyChanged();
                }
            }
        }

        ObservableCollection<TaskModel> tasks;
        public ObservableCollection<TaskModel> Tasks {
            get { return tasks; }
            set {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }


        private List<TaskModel> TaskModels;
        public TaskViewModel() { 
            Tasks = new ObservableCollection<TaskModel>();
            TaskModels = new List<TaskModel>();

            Save = new Command(() =>
            {
                TaskModel task = new TaskModel();
                task.title = this.Title;
                task.description = this.Description;
                task.isCompleted = this.IsCompleted;
                TaskModels.Add(task);
                Console.WriteLine(TaskModels.Count);
            }
            );
            Get = new Command(() =>
            {
                Tasks = new ObservableCollection<TaskModel>(TaskModels);
            });
        }
    }
}
