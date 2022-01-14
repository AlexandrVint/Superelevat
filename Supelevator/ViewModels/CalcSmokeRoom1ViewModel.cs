

using Supelevator.ViewModels.Base;
using Supelevator.Infrastructure.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Supelevator.ViewModels
{
    internal class CalcSmokeRoom1ViewModel : ViewModel
    {
        #region Заголовой окна
        private string _Title = "Окно шаблона программы";
        /// <summary>
        /// Заголовок окна
        /// </summary>

        public string Title
        {
            get => _Title;
            //set
            //{
            //    if (Equals(_Title, value)) return;
            //    _Title = value;
            //    OnPropertyChanged();

            //    этому аналог код ниже

            //}
            set => Set(ref _Title, value);
        }
        #endregion

        #region Status:string - Статус программы
        ///<summary> Статус программы</summary>
        private string _Status = "Готов!";
        ///<summary> Статус программы</summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        #endregion

        #region Команды

        #region Команда закрытия приложения - CloseApplicationCommand
        //свойство команды CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        // методы команды CloseApplicationCommand
        private void OnCloseApplicationCommandExecited(object p)
        {
            Application.Current.Shutdown();
        }
        private bool CanCloseApplicationCommandExecute(object p) => true;

        #endregion

        #endregion

        //конструктор окна CloseApplicationCommand
        public CalcSmokeRoom1ViewModel()
        {

            #region Команды
            // создается екземпляр класса команды LambdaCommand с названием CloseApplicationCommand  
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecited, CanCloseApplicationCommandExecute);
            #endregion

        }


    }
}
