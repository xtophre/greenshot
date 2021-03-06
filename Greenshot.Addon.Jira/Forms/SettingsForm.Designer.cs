﻿/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2007-2016 Thomas Braun, Jens Klingen, Robin Krom
 * 
 * For more information see: http://getgreenshot.org/
 * The Greenshot project is hosted on GitHub: https://github.com/greenshot
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Greenshot.Addon.Controls;

namespace Greenshot.Addon.Jira.Forms {
	partial class SettingsForm {
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.buttonOK = new GreenshotButton();
			this.buttonCancel = new GreenshotButton();
			this.label_url = new GreenshotLabel();
			this.label_username = new GreenshotLabel();
			this.label_password = new GreenshotLabel();
			this.textBoxUrl = new GreenshotTextBox();
			this.textBoxUsername = new GreenshotTextBox();
			this.textBoxPassword = new GreenshotTextBox();
			this.combobox_uploadimageformat = new GreenshotComboBox();
			this.label_upload_format = new GreenshotLabel();
			this.label_pattern = new GreenshotLabel();
			this.pattern_textbox = new GreenshotTextBox();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.LanguageKey = "OK";
			this.buttonOK.Location = new System.Drawing.Point(224, 157);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.LanguageKey = "CANCEL";
			this.buttonCancel.Location = new System.Drawing.Point(305, 157);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 12;
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// label_url
			// 
			this.label_url.LanguageKey = "label_url";
			this.label_url.LanguageModule = "jira";
			this.label_url.Location = new System.Drawing.Point(12, 19);
			this.label_url.Name = "label_url";
			this.label_url.Size = new System.Drawing.Size(146, 20);
			this.label_url.TabIndex = 6;
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxUrl.Location = new System.Drawing.Point(164, 19);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.PropertyName = "RestUrl";
			this.textBoxUrl.SectionName = "Jira";
			this.textBoxUrl.Size = new System.Drawing.Size(214, 20);
			this.textBoxUrl.TabIndex = 6;
			// 
			// label_username
			// 
			this.label_username.LanguageKey = "label_username";
			this.label_username.LanguageModule = "jira";
			this.label_username.Location = new System.Drawing.Point(12, 45);
			this.label_username.Name = "label_username";
			this.label_username.Size = new System.Drawing.Size(146, 20);
			this.label_username.TabIndex = 7;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxUsername.Location = new System.Drawing.Point(164, 45);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.PropertyName = "Username";
			this.textBoxUsername.SectionName = "Jira";
			this.textBoxUsername.Size = new System.Drawing.Size(214, 20);
			this.textBoxUsername.TabIndex = 7;
			// 
			// label_password
			// 
			this.label_password.LanguageKey = "label_password";
			this.label_password.LanguageModule = "jira";
			this.label_password.Location = new System.Drawing.Point(12, 71);
			this.label_password.Name = "label_password";
			this.label_password.Size = new System.Drawing.Size(146, 20);
			this.label_password.TabIndex = 8;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPassword.Location = new System.Drawing.Point(164, 71);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PropertyName = "Password";
			this.textBoxPassword.SectionName = "Jira";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(214, 20);
			this.textBoxPassword.TabIndex = 8;
			// 
			// label_upload_format
			// 
			this.label_upload_format.LanguageKey = "label_upload_format";
			this.label_upload_format.LanguageModule = "jira";
			this.label_upload_format.Location = new System.Drawing.Point(12, 97);
			this.label_upload_format.Name = "label_upload_format";
			this.label_upload_format.Size = new System.Drawing.Size(146, 20);
			this.label_upload_format.TabIndex = 9;
			// 
			// combobox_uploadimageformat
			// 
			this.combobox_uploadimageformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combobox_uploadimageformat.FormattingEnabled = true;
			this.combobox_uploadimageformat.Location = new System.Drawing.Point(164, 97);
			this.combobox_uploadimageformat.Name = "combobox_uploadimageformat";
			this.combobox_uploadimageformat.PropertyName = "UploadFormat";
			this.combobox_uploadimageformat.SectionName = "Jira";
			this.combobox_uploadimageformat.Size = new System.Drawing.Size(214, 21);
			this.combobox_uploadimageformat.TabIndex = 9;

			// 
			// label_pattern
			// 
			this.label_pattern.LanguageKey = "label_pattern";
			this.label_pattern.LanguageModule = "jira";
			this.label_pattern.Location = new System.Drawing.Point(12, 124);
			this.label_pattern.Name = "label_pattern";
			this.label_pattern.Size = new System.Drawing.Size(146, 20);
			this.label_pattern.TabIndex = 10;
			// 
			// pattern_textbox
			// 
			this.pattern_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pattern_textbox.Location = new System.Drawing.Point(164, 124);
			this.pattern_textbox.Name = "pattern_textbox";
			this.pattern_textbox.PropertyName = "FilenamePattern";
			this.pattern_textbox.SectionName = "Jira";
			this.pattern_textbox.Size = new System.Drawing.Size(214, 20);
			this.pattern_textbox.TabIndex = 10;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(387, 192);
			this.Controls.Add(this.label_pattern);
			this.Controls.Add(this.pattern_textbox);
			this.Controls.Add(this.label_upload_format);
			this.Controls.Add(this.combobox_uploadimageformat);
			this.Controls.Add(this.label_url);
			this.Controls.Add(this.label_username);
			this.Controls.Add(this.label_password);
			this.Controls.Add(this.textBoxUrl);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.LanguageKey = "settings_title";
			this.LanguageModule = "jira";
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private GreenshotComboBox combobox_uploadimageformat;
		private GreenshotLabel label_upload_format;
		private GreenshotTextBox textBoxUrl;
		private GreenshotTextBox textBoxUsername;
		private GreenshotTextBox textBoxPassword;
		private GreenshotLabel label_url;
		private GreenshotLabel label_username;
		private GreenshotLabel label_password;
		private GreenshotButton buttonCancel;
		private GreenshotButton buttonOK;
		private GreenshotLabel label_pattern;
		private GreenshotTextBox pattern_textbox;
	}
}
