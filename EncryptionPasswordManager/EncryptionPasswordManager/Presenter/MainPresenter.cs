﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using EncryptionPasswordManager.Forms;
using EncryptionPasswordManager.Model;

namespace EncryptionPasswordManager.Presenter
{
    public class MainPresenter
    {
        private readonly IMainForm _form;
        private PasswordItemModel _model;
        public MainPresenter(IMainForm form)
        {
            _form = form;
            _model = new PasswordItemModel();
            _form.AddNewPasswordEvent += AddNewPassword;
            _form.RemovePasswordEvent += RemovePassword;
            _form.CreateQuickEncryptedEvent += QuickEncryptedPassword;
            _form.CopyPasswordEvent += CopyPassword;
            _form.ViewPasswordEvent += ViewPasswords;

            PopulateView(_model.GetResult(String.Empty));
        }

        public void PopulateView(List<PasswordItem> populateViewList)
        {
            _form.PopulateData(populateViewList);
        }

        public void ProcessQuery(String query)
        {
            PopulateView(_model.GetResult(query));
        }

        private void ViewPasswords(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CopyPassword(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void QuickEncryptedPassword(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RemovePassword(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPassword(object sender, EventArgs e)
        {
            PasswordCreationForm form = new PasswordCreationForm(_model);
            if(form.ShowDialog() == DialogResult.OK)
            {
                PopulateView(_model.GetResult(String.Empty));
            }
        }
    }
}