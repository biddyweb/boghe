﻿/*
* Boghe IMS/RCS Client - Copyright (C) 2010 Mamadou Diop.
*
* Contact: Mamadou Diop <diopmamadou(at)doubango.org>
*	
* This file is part of Boghe Project (http://code.google.com/p/boghe)
*
* Boghe is free software: you can redistribute it and/or modify it under the terms of 
* the GNU General Public License as published by the Free Software Foundation, either version 3 
* of the License, or (at your option) any later version.
*	
* Boghe is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
* See the GNU General Public License for more details.
*	
* You should have received a copy of the GNU General Public License along 
* with this program; if not, write to the Free Software Foundation, Inc., 
* 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
*
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BogheControls;
using BogheCore.Model;
using BogheCore.Services;
using BogheApp.Services.Impl;
using BogheApp.Services;

namespace BogheApp.Screens
{
    /// <summary>
    /// Interaction logic for ScreenContactEdit.xaml
    /// </summary>
    public partial class ScreenContactEdit : BaseScreen
    {
        private Contact contact;
        private bool editMode;

        private readonly IContactService contactService;
        private readonly IWin32ScreenService screenService;

        public ScreenContactEdit(Contact contact, Group group) : base()
        {
            InitializeComponent();

            if ((this.contact = contact) != null)
            {
                this.textBoxSipUri.Text = this.contact.UriString ?? this.contact.UriString;
                this.textBoxDisplayName.Text = this.contact.DisplayName ?? this.contact.DisplayName;
                this.textBoxSipUri.IsEnabled = false;
                this.editMode = true;
                this.labelTitle.Content = "Edit Contact";
            }
            else
            {
                String realm = Win32ServiceManager.SharedManager.ConfigurationService.Get(Configuration.ConfFolder.NETWORK, 
                    Configuration.ConfEntry.REALM, Configuration.DEFAULT_REALM);
                this.contact = new Contact();
                if (group != null)
                {
                    this.contact.GroupName = group.Name;
                }
                this.textBoxSipUri.Text = this.contact.UriString = String.Format("sip:johndoe@{0}", realm.Replace("sip:", String.Empty));
                this.textBoxDisplayName.Text = this.contact.DisplayName = "John Doe";
                this.textBoxSipUri.IsEnabled = true;
                this.editMode = false;
                this.labelTitle.Content = "Add Contact";
            }

            this.contactService = Win32ServiceManager.SharedManager.ContactService;
            this.screenService = Win32ServiceManager.SharedManager.Win32ScreenService;
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            if (this.comboBoxGroup.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a group", "Invalid Group");
                return;
            }

            if (this.contact == null)
            {
                this.contact = new Contact();
            }

            Group group = this.comboBoxGroup.SelectedItem as Group;
            this.contact.DisplayName = this.textBoxDisplayName.Text;
            this.contact.UriString = this.textBoxSipUri.Text;
            this.contact.GroupName = group.Name;

            if (this.editMode)
            {
                this.contactService.ContactUpdate(this.contact, group.Name);
            }
            else
            {
                this.contactService.ContactAdd(this.contact);
            }
            this.screenService.Show(ScreenType.Contacts);
            this.screenService.Hide(this);
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.screenService.Show(ScreenType.Contacts);
            this.screenService.Hide(this);
        }
    }
}
