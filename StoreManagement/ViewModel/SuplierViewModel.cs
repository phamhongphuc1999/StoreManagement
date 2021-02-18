using StoreManagement.Data.Services;
using StoreManagement.Model;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace StoreManagement.ViewModel
{
    public class SuplierViewModel: BaseViewModel
    {
        private SuplierService suplierService;

        public ICommand AddSuplierCommand { get; set; }
        public ICommand EditSuplierCommand { get; set; }
        public ICommand DeleteSuplierCommand { get; set; }

        private List<Suplier> suplierList;
        public List<Suplier> SuplierList
        {
            get { return suplierList; }
            set
            {
                suplierList = value;
                OnPropertyChanged();
            }
        }

        private string displayName;
        public string DisplayName
        {
            get { return displayName; }
            set
            {
                displayName = value;
                OnPropertyChanged();
            }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
                OnPropertyChanged();
            }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged();
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }

        private string moreInfo;
        public string MoreInfo
        {
            get { return moreInfo; }
            set
            {
                moreInfo = value;
                OnPropertyChanged();
            }
        }

        private DateTime contractDate;
        public DateTime ContractDate
        {
            get { return contractDate; }
            set
            {
                contractDate = value;
                OnPropertyChanged();
            }
        }

        private Suplier selectedSuplierItem;
        public Suplier SelectedSuplierItem
        {
            get { return selectedSuplierItem; }
            set
            {
                selectedSuplierItem = value;
                if(selectedSuplierItem != null)
                {
                    DisplayName = selectedSuplierItem.DisplayName;
                    Address = selectedSuplierItem.Address;
                    Phone = selectedSuplierItem.Phone;
                    Email = selectedSuplierItem.Email;
                    MoreInfo = selectedSuplierItem.MoreInfo;
                    ContractDate = selectedSuplierItem.ContractDate;
                }
                OnPropertyChanged();
            }
        }

        public SuplierViewModel()
        {
            suplierService = new SuplierService();
            SuplierList = suplierService.GetListSupliers();

            InitializeAddSuplierCommand();
            InitializeEditSuplierCommand();
            InitializeDeleteSuplierCommand();
        }

        private void InitializeAddSuplierCommand()
        {
            AddSuplierCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {
                    
                });
        }

        private void InitializeEditSuplierCommand()
        {
            EditSuplierCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {

                });
        }

        private void InitializeDeleteSuplierCommand()
        {
            DeleteSuplierCommand = new RelayCommand<object>(
                sender => { return true; }, sender =>
                {

                });
        }
    }
}
