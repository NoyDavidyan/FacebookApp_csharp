﻿namespace MyFacebookApp
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.UserTabControl = new System.Windows.Forms.TabControl();
            this.EventsTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EventsGroupBox = new System.Windows.Forms.GroupBox();
            this.NotRepliedRadioButton = new System.Windows.Forms.RadioButton();
            this.AttendingRadioButton = new System.Windows.Forms.RadioButton();
            this.MaybeRadioButton = new System.Windows.Forms.RadioButton();
            this.NotAttendingRadioButton = new System.Windows.Forms.RadioButton();
            this.EventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OwnerNameLabel = new System.Windows.Forms.Label();
            this.Ownerlabel = new System.Windows.Forms.Label();
            this.SelectedEventPictureBox = new System.Windows.Forms.PictureBox();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.CheckInsTab = new System.Windows.Forms.TabPage();
            this.ShowCheckInsButton = new System.Windows.Forms.Button();
            this.FetchCheckInsButton = new System.Windows.Forms.Button();
            this.CheckInsListBox = new System.Windows.Forms.ListBox();
            this.HoroscopeTab = new System.Windows.Forms.TabPage();
            this.SignPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectsPartnerButton = new System.Windows.Forms.Button();
            this.GetMathcesButton = new System.Windows.Forms.Button();
            this.FetchHoroscopeButton = new System.Windows.Forms.Button();
            this.ZodiacSignLabel = new System.Windows.Forms.Label();
            this.HoroscopeTextBox = new System.Windows.Forms.TextBox();
            this.HoroscopeBirthdayLabel = new System.Windows.Forms.Label();
            this.PlaylistTabPage = new System.Windows.Forms.TabPage();
            this.GetPlaylistButton = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Notes1PictureBox = new System.Windows.Forms.PictureBox();
            this.AlbumsTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.AlbumDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AlbumDescriptionLabel = new System.Windows.Forms.Label();
            this.CreateAlbumLabel = new System.Windows.Forms.Label();
            this.AlbumCreatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateAlbumButton = new System.Windows.Forms.Button();
            this.FetchAlbumsButton = new System.Windows.Forms.Button();
            this.AlbumsOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.SelectedAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.PostsTab = new System.Windows.Forms.TabPage();
            this.FetchPostsButton = new System.Windows.Forms.Button();
            this.PostsListBox = new System.Windows.Forms.ListBox();
            this.FriendListTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.FriendsLastNameOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.FetchFriendButton = new System.Windows.Forms.Button();
            this.FriendsFirstNameOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.FriendCheckedPictureBox = new System.Windows.Forms.PictureBox();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.LikedPagesTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.FetchLikedPagesButton = new System.Windows.Forms.Button();
            this.LikedPagesInOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.LikedPagePictureBox = new System.Windows.Forms.PictureBox();
            this.LikedPagesListBox = new System.Windows.Forms.ListBox();
            this.GetInTouchTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GetInThouchPictureBox = new System.Windows.Forms.PictureBox();
            this.Hearts2PictureBox = new System.Windows.Forms.PictureBox();
            this.HeartsPictureBox = new System.Windows.Forms.PictureBox();
            this.SingelsFriendsListBox = new System.Windows.Forms.ListBox();
            this.FetchSingelsFriendsButton = new System.Windows.Forms.Button();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.UserBirthdayLabel = new System.Windows.Forms.Label();
            this.UserEmailLabel = new System.Windows.Forms.Label();
            this.UserLivesInLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.PostStatusButton = new System.Windows.Forms.Button();
            this.UserInterestedInLabel = new System.Windows.Forms.Label();
            this.UserGenderLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.UiDateHLabel = new System.Windows.Forms.Label();
            this.TimeUILabel = new System.Windows.Forms.Label();
            this.DateUiLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.HBIrthdayLlabel = new System.Windows.Forms.Label();
            this.UserProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.CoverPictureBox = new System.Windows.Forms.PictureBox();
            this.UserTabControl.SuspendLayout();
            this.EventsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.EventsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedEventPictureBox)).BeginInit();
            this.CheckInsTab.SuspendLayout();
            this.HoroscopeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignPictureBox)).BeginInit();
            this.PlaylistTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notes1PictureBox)).BeginInit();
            this.AlbumsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedAlbumPictureBox)).BeginInit();
            this.PostsTab.SuspendLayout();
            this.FriendListTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendCheckedPictureBox)).BeginInit();
            this.LikedPagesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikedPagePictureBox)).BeginInit();
            this.GetInTouchTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetInThouchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hearts2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(185, 245);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(47, 52);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "...";
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(1071, 420);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(155, 46);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // UserTabControl
            // 
            this.UserTabControl.Controls.Add(this.EventsTab);
            this.UserTabControl.Controls.Add(this.CheckInsTab);
            this.UserTabControl.Controls.Add(this.HoroscopeTab);
            this.UserTabControl.Controls.Add(this.PlaylistTabPage);
            this.UserTabControl.Controls.Add(this.AlbumsTab);
            this.UserTabControl.Controls.Add(this.PostsTab);
            this.UserTabControl.Controls.Add(this.FriendListTab);
            this.UserTabControl.Controls.Add(this.LikedPagesTab);
            this.UserTabControl.Controls.Add(this.GetInTouchTab);
            this.UserTabControl.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTabControl.Location = new System.Drawing.Point(1, 469);
            this.UserTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.UserTabControl.Name = "UserTabControl";
            this.UserTabControl.SelectedIndex = 0;
            this.UserTabControl.Size = new System.Drawing.Size(1240, 351);
            this.UserTabControl.TabIndex = 3;
            // 
            // EventsTab
            // 
            this.EventsTab.BackColor = System.Drawing.Color.Snow;
            this.EventsTab.Controls.Add(this.label1);
            this.EventsTab.Controls.Add(this.pictureBox1);
            this.EventsTab.Controls.Add(this.EventsGroupBox);
            this.EventsTab.Controls.Add(this.EventDescriptionTextBox);
            this.EventsTab.Controls.Add(this.DescriptionLabel);
            this.EventsTab.Controls.Add(this.EndTimeLabel);
            this.EventsTab.Controls.Add(this.StartTimeLabel);
            this.EventsTab.Controls.Add(this.EndDateTimePicker);
            this.EventsTab.Controls.Add(this.StartDateTimePicker);
            this.EventsTab.Controls.Add(this.OwnerNameLabel);
            this.EventsTab.Controls.Add(this.Ownerlabel);
            this.EventsTab.Controls.Add(this.SelectedEventPictureBox);
            this.EventsTab.Controls.Add(this.EventsListBox);
            this.EventsTab.Location = new System.Drawing.Point(4, 42);
            this.EventsTab.Margin = new System.Windows.Forms.Padding(4);
            this.EventsTab.Name = "EventsTab";
            this.EventsTab.Padding = new System.Windows.Forms.Padding(4);
            this.EventsTab.Size = new System.Drawing.Size(1232, 305);
            this.EventsTab.TabIndex = 0;
            this.EventsTab.Text = "Events";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(997, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 50);
            this.label1.TabIndex = 23;
            this.label1.Text = "Press on event from list to see details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MyFacebookApp.Properties.Resources.Info;
            this.pictureBox1.Location = new System.Drawing.Point(971, 230);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // EventsGroupBox
            // 
            this.EventsGroupBox.Controls.Add(this.NotRepliedRadioButton);
            this.EventsGroupBox.Controls.Add(this.AttendingRadioButton);
            this.EventsGroupBox.Controls.Add(this.MaybeRadioButton);
            this.EventsGroupBox.Controls.Add(this.NotAttendingRadioButton);
            this.EventsGroupBox.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsGroupBox.ForeColor = System.Drawing.Color.Black;
            this.EventsGroupBox.Location = new System.Drawing.Point(963, 4);
            this.EventsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.EventsGroupBox.Name = "EventsGroupBox";
            this.EventsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.EventsGroupBox.Size = new System.Drawing.Size(245, 145);
            this.EventsGroupBox.TabIndex = 22;
            this.EventsGroupBox.TabStop = false;
            this.EventsGroupBox.Text = "Choose Events To Show:";
            // 
            // NotRepliedRadioButton
            // 
            this.NotRepliedRadioButton.AutoSize = true;
            this.NotRepliedRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotRepliedRadioButton.Location = new System.Drawing.Point(8, 108);
            this.NotRepliedRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.NotRepliedRadioButton.Name = "NotRepliedRadioButton";
            this.NotRepliedRadioButton.Size = new System.Drawing.Size(198, 34);
            this.NotRepliedRadioButton.TabIndex = 8;
            this.NotRepliedRadioButton.Text = "Not Replied Events";
            this.NotRepliedRadioButton.UseVisualStyleBackColor = true;
            this.NotRepliedRadioButton.Click += new System.EventHandler(this.notRepliedRadioButton_Click);
            // 
            // AttendingRadioButton
            // 
            this.AttendingRadioButton.AutoSize = true;
            this.AttendingRadioButton.Checked = true;
            this.AttendingRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendingRadioButton.Location = new System.Drawing.Point(8, 23);
            this.AttendingRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.AttendingRadioButton.Name = "AttendingRadioButton";
            this.AttendingRadioButton.Size = new System.Drawing.Size(183, 34);
            this.AttendingRadioButton.TabIndex = 5;
            this.AttendingRadioButton.TabStop = true;
            this.AttendingRadioButton.Text = "Attending Events";
            this.AttendingRadioButton.UseVisualStyleBackColor = true;
            this.AttendingRadioButton.Click += new System.EventHandler(this.attendingRadioButton_Click);
            // 
            // MaybeRadioButton
            // 
            this.MaybeRadioButton.AutoSize = true;
            this.MaybeRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaybeRadioButton.Location = new System.Drawing.Point(8, 80);
            this.MaybeRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.MaybeRadioButton.Name = "MaybeRadioButton";
            this.MaybeRadioButton.Size = new System.Drawing.Size(152, 34);
            this.MaybeRadioButton.TabIndex = 7;
            this.MaybeRadioButton.Text = "Maybe Events";
            this.MaybeRadioButton.UseVisualStyleBackColor = true;
            this.MaybeRadioButton.Click += new System.EventHandler(this.maybeRadioButton_Click);
            // 
            // NotAttendingRadioButton
            // 
            this.NotAttendingRadioButton.AutoSize = true;
            this.NotAttendingRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotAttendingRadioButton.Location = new System.Drawing.Point(8, 52);
            this.NotAttendingRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.NotAttendingRadioButton.Name = "NotAttendingRadioButton";
            this.NotAttendingRadioButton.Size = new System.Drawing.Size(222, 34);
            this.NotAttendingRadioButton.TabIndex = 6;
            this.NotAttendingRadioButton.Text = "Not Attending Events";
            this.NotAttendingRadioButton.UseVisualStyleBackColor = true;
            this.NotAttendingRadioButton.Click += new System.EventHandler(this.notAttendingRadioButton_Click);
            // 
            // EventDescriptionTextBox
            // 
            this.EventDescriptionTextBox.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventDescriptionTextBox.Location = new System.Drawing.Point(17, 223);
            this.EventDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EventDescriptionTextBox.Multiline = true;
            this.EventDescriptionTextBox.Name = "EventDescriptionTextBox";
            this.EventDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EventDescriptionTextBox.Size = new System.Drawing.Size(401, 67);
            this.EventDescriptionTextBox.TabIndex = 20;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 193);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(101, 26);
            this.DescriptionLabel.TabIndex = 19;
            this.DescriptionLabel.Text = "Description:";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.EndTimeLabel.Location = new System.Drawing.Point(12, 159);
            this.EndTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(71, 26);
            this.EndTimeLabel.TabIndex = 18;
            this.EndTimeLabel.Text = "End At:";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.StartTimeLabel.Location = new System.Drawing.Point(12, 126);
            this.StartTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(82, 26);
            this.StartTimeLabel.TabIndex = 17;
            this.StartTimeLabel.Text = "Start At:";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.EndDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Firebrick;
            this.EndDateTimePicker.Enabled = false;
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.EndDateTimePicker.Location = new System.Drawing.Point(121, 158);
            this.EndDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(296, 23);
            this.EndDateTimePicker.TabIndex = 16;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.StartDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Firebrick;
            this.StartDateTimePicker.Enabled = false;
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.StartDateTimePicker.Location = new System.Drawing.Point(121, 126);
            this.StartDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(296, 23);
            this.StartDateTimePicker.TabIndex = 15;
            // 
            // OwnerNameLabel
            // 
            this.OwnerNameLabel.AutoSize = true;
            this.OwnerNameLabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.OwnerNameLabel.Location = new System.Drawing.Point(147, 92);
            this.OwnerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OwnerNameLabel.Name = "OwnerNameLabel";
            this.OwnerNameLabel.Size = new System.Drawing.Size(125, 26);
            this.OwnerNameLabel.TabIndex = 14;
            this.OwnerNameLabel.Text = "[Owner Name]";
            // 
            // Ownerlabel
            // 
            this.Ownerlabel.AutoSize = true;
            this.Ownerlabel.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.Ownerlabel.Location = new System.Drawing.Point(11, 92);
            this.Ownerlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ownerlabel.Name = "Ownerlabel";
            this.Ownerlabel.Size = new System.Drawing.Size(116, 26);
            this.Ownerlabel.TabIndex = 13;
            this.Ownerlabel.Text = "Event Owner:";
            // 
            // SelectedEventPictureBox
            // 
            this.SelectedEventPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SelectedEventPictureBox.Image = global::MyFacebookApp.Properties.Resources.event2;
            this.SelectedEventPictureBox.Location = new System.Drawing.Point(16, 6);
            this.SelectedEventPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.SelectedEventPictureBox.Name = "SelectedEventPictureBox";
            this.SelectedEventPictureBox.Size = new System.Drawing.Size(96, 84);
            this.SelectedEventPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectedEventPictureBox.TabIndex = 12;
            this.SelectedEventPictureBox.TabStop = false;
            // 
            // EventsListBox
            // 
            this.EventsListBox.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.ItemHeight = 28;
            this.EventsListBox.Location = new System.Drawing.Point(432, 15);
            this.EventsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(521, 256);
            this.EventsListBox.TabIndex = 0;
            this.EventsListBox.SelectedIndexChanged += new System.EventHandler(this.eventsListBox_SelectedIndexChanged);
            // 
            // CheckInsTab
            // 
            this.CheckInsTab.BackColor = System.Drawing.Color.Snow;
            this.CheckInsTab.Controls.Add(this.ShowCheckInsButton);
            this.CheckInsTab.Controls.Add(this.FetchCheckInsButton);
            this.CheckInsTab.Controls.Add(this.CheckInsListBox);
            this.CheckInsTab.Location = new System.Drawing.Point(4, 42);
            this.CheckInsTab.Margin = new System.Windows.Forms.Padding(4);
            this.CheckInsTab.Name = "CheckInsTab";
            this.CheckInsTab.Size = new System.Drawing.Size(1232, 305);
            this.CheckInsTab.TabIndex = 3;
            this.CheckInsTab.Text = "Check Ins";
            // 
            // ShowCheckInsButton
            // 
            this.ShowCheckInsButton.Location = new System.Drawing.Point(16, 73);
            this.ShowCheckInsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowCheckInsButton.Name = "ShowCheckInsButton";
            this.ShowCheckInsButton.Size = new System.Drawing.Size(128, 124);
            this.ShowCheckInsButton.TabIndex = 10;
            this.ShowCheckInsButton.Text = "Show Locations On Map";
            this.ShowCheckInsButton.UseVisualStyleBackColor = true;
            this.ShowCheckInsButton.Click += new System.EventHandler(this.showCheckInsButton_Click);
            // 
            // FetchCheckInsButton
            // 
            this.FetchCheckInsButton.Location = new System.Drawing.Point(16, 12);
            this.FetchCheckInsButton.Margin = new System.Windows.Forms.Padding(4);
            this.FetchCheckInsButton.Name = "FetchCheckInsButton";
            this.FetchCheckInsButton.Size = new System.Drawing.Size(128, 53);
            this.FetchCheckInsButton.TabIndex = 9;
            this.FetchCheckInsButton.Text = "Fetch";
            this.FetchCheckInsButton.UseVisualStyleBackColor = true;
            this.FetchCheckInsButton.Click += new System.EventHandler(this.fetchCheckInsButton_Click);
            // 
            // CheckInsListBox
            // 
            this.CheckInsListBox.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.CheckInsListBox.FormattingEnabled = true;
            this.CheckInsListBox.ItemHeight = 28;
            this.CheckInsListBox.Location = new System.Drawing.Point(152, 11);
            this.CheckInsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckInsListBox.Name = "CheckInsListBox";
            this.CheckInsListBox.Size = new System.Drawing.Size(1049, 256);
            this.CheckInsListBox.TabIndex = 8;
            // 
            // HoroscopeTab
            // 
            this.HoroscopeTab.BackColor = System.Drawing.Color.White;
            this.HoroscopeTab.Controls.Add(this.SignPictureBox);
            this.HoroscopeTab.Controls.Add(this.SelectsPartnerButton);
            this.HoroscopeTab.Controls.Add(this.GetMathcesButton);
            this.HoroscopeTab.Controls.Add(this.FetchHoroscopeButton);
            this.HoroscopeTab.Controls.Add(this.ZodiacSignLabel);
            this.HoroscopeTab.Controls.Add(this.HoroscopeTextBox);
            this.HoroscopeTab.Controls.Add(this.HoroscopeBirthdayLabel);
            this.HoroscopeTab.Location = new System.Drawing.Point(4, 42);
            this.HoroscopeTab.Margin = new System.Windows.Forms.Padding(4);
            this.HoroscopeTab.Name = "HoroscopeTab";
            this.HoroscopeTab.Size = new System.Drawing.Size(1232, 305);
            this.HoroscopeTab.TabIndex = 6;
            this.HoroscopeTab.Text = "Horoscope";
            // 
            // SignPictureBox
            // 
            this.SignPictureBox.Location = new System.Drawing.Point(972, 15);
            this.SignPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.SignPictureBox.Name = "SignPictureBox";
            this.SignPictureBox.Size = new System.Drawing.Size(112, 107);
            this.SignPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SignPictureBox.TabIndex = 13;
            this.SignPictureBox.TabStop = false;
            // 
            // SelectsPartnerButton
            // 
            this.SelectsPartnerButton.BackColor = System.Drawing.Color.Pink;
            this.SelectsPartnerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.SelectsPartnerButton.Location = new System.Drawing.Point(887, 187);
            this.SelectsPartnerButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectsPartnerButton.Name = "SelectsPartnerButton";
            this.SelectsPartnerButton.Size = new System.Drawing.Size(284, 44);
            this.SelectsPartnerButton.TabIndex = 12;
            this.SelectsPartnerButton.Text = "Select Partner Sign";
            this.SelectsPartnerButton.UseVisualStyleBackColor = false;
            this.SelectsPartnerButton.Click += new System.EventHandler(this.selectsPartnerButton_Click);
            // 
            // GetMathcesButton
            // 
            this.GetMathcesButton.BackColor = System.Drawing.Color.Pink;
            this.GetMathcesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.GetMathcesButton.Location = new System.Drawing.Point(887, 245);
            this.GetMathcesButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetMathcesButton.Name = "GetMathcesButton";
            this.GetMathcesButton.Size = new System.Drawing.Size(284, 44);
            this.GetMathcesButton.TabIndex = 11;
            this.GetMathcesButton.Text = "Get Your Matches";
            this.GetMathcesButton.UseVisualStyleBackColor = false;
            this.GetMathcesButton.Click += new System.EventHandler(this.getMathcesButton_Click);
            // 
            // FetchHoroscopeButton
            // 
            this.FetchHoroscopeButton.BackColor = System.Drawing.Color.Pink;
            this.FetchHoroscopeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(128)))));
            this.FetchHoroscopeButton.Location = new System.Drawing.Point(887, 129);
            this.FetchHoroscopeButton.Margin = new System.Windows.Forms.Padding(4);
            this.FetchHoroscopeButton.Name = "FetchHoroscopeButton";
            this.FetchHoroscopeButton.Size = new System.Drawing.Size(284, 44);
            this.FetchHoroscopeButton.TabIndex = 10;
            this.FetchHoroscopeButton.Text = "Fetch daily horoscope";
            this.FetchHoroscopeButton.UseVisualStyleBackColor = false;
            this.FetchHoroscopeButton.Click += new System.EventHandler(this.fetchHoroscopeButton_Click);
            // 
            // ZodiacSignLabel
            // 
            this.ZodiacSignLabel.AutoSize = true;
            this.ZodiacSignLabel.Font = new System.Drawing.Font("Segoe Print", 12.5F);
            this.ZodiacSignLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.ZodiacSignLabel.Location = new System.Drawing.Point(348, 15);
            this.ZodiacSignLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZodiacSignLabel.Name = "ZodiacSignLabel";
            this.ZodiacSignLabel.Size = new System.Drawing.Size(164, 36);
            this.ZodiacSignLabel.TabIndex = 9;
            this.ZodiacSignLabel.Text = "Zodiac sign: ...";
            // 
            // HoroscopeTextBox
            // 
            this.HoroscopeTextBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.HoroscopeTextBox.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.HoroscopeTextBox.ForeColor = System.Drawing.Color.Purple;
            this.HoroscopeTextBox.Location = new System.Drawing.Point(24, 65);
            this.HoroscopeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HoroscopeTextBox.Multiline = true;
            this.HoroscopeTextBox.Name = "HoroscopeTextBox";
            this.HoroscopeTextBox.ReadOnly = true;
            this.HoroscopeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HoroscopeTextBox.Size = new System.Drawing.Size(835, 227);
            this.HoroscopeTextBox.TabIndex = 8;
            this.HoroscopeTextBox.Text = "Horoscop";
            // 
            // HoroscopeBirthdayLabel
            // 
            this.HoroscopeBirthdayLabel.AutoSize = true;
            this.HoroscopeBirthdayLabel.Font = new System.Drawing.Font("Segoe Print", 12.5F);
            this.HoroscopeBirthdayLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.HoroscopeBirthdayLabel.Location = new System.Drawing.Point(29, 14);
            this.HoroscopeBirthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HoroscopeBirthdayLabel.Name = "HoroscopeBirthdayLabel";
            this.HoroscopeBirthdayLabel.Size = new System.Drawing.Size(137, 36);
            this.HoroscopeBirthdayLabel.TabIndex = 7;
            this.HoroscopeBirthdayLabel.Text = "Birthday: ...";
            // 
            // PlaylistTabPage
            // 
            this.PlaylistTabPage.BackColor = System.Drawing.Color.White;
            this.PlaylistTabPage.Controls.Add(this.GetPlaylistButton);
            this.PlaylistTabPage.Controls.Add(this.pictureBox6);
            this.PlaylistTabPage.Controls.Add(this.Notes1PictureBox);
            this.PlaylistTabPage.Location = new System.Drawing.Point(4, 42);
            this.PlaylistTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.PlaylistTabPage.Name = "PlaylistTabPage";
            this.PlaylistTabPage.Size = new System.Drawing.Size(1232, 305);
            this.PlaylistTabPage.TabIndex = 8;
            this.PlaylistTabPage.Text = "Playlist";
            // 
            // GetPlaylistButton
            // 
            this.GetPlaylistButton.BackColor = System.Drawing.Color.Black;
            this.GetPlaylistButton.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetPlaylistButton.ForeColor = System.Drawing.Color.Thistle;
            this.GetPlaylistButton.Location = new System.Drawing.Point(444, 180);
            this.GetPlaylistButton.Margin = new System.Windows.Forms.Padding(4);
            this.GetPlaylistButton.Name = "GetPlaylistButton";
            this.GetPlaylistButton.Size = new System.Drawing.Size(305, 66);
            this.GetPlaylistButton.TabIndex = 0;
            this.GetPlaylistButton.Text = "Get Playlist!";
            this.GetPlaylistButton.UseVisualStyleBackColor = false;
            this.GetPlaylistButton.Click += new System.EventHandler(this.getPlaylistButton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MyFacebookApp.Properties.Resources.music2;
            this.pictureBox6.Location = new System.Drawing.Point(748, 0);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(464, 246);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // Notes1PictureBox
            // 
            this.Notes1PictureBox.Image = global::MyFacebookApp.Properties.Resources.music1;
            this.Notes1PictureBox.Location = new System.Drawing.Point(0, 44);
            this.Notes1PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.Notes1PictureBox.Name = "Notes1PictureBox";
            this.Notes1PictureBox.Size = new System.Drawing.Size(451, 230);
            this.Notes1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Notes1PictureBox.TabIndex = 1;
            this.Notes1PictureBox.TabStop = false;
            // 
            // AlbumsTab
            // 
            this.AlbumsTab.BackColor = System.Drawing.Color.Snow;
            this.AlbumsTab.Controls.Add(this.label5);
            this.AlbumsTab.Controls.Add(this.AlbumDescriptionTextBox);
            this.AlbumsTab.Controls.Add(this.AlbumDescriptionLabel);
            this.AlbumsTab.Controls.Add(this.CreateAlbumLabel);
            this.AlbumsTab.Controls.Add(this.AlbumCreatedDateTimePicker);
            this.AlbumsTab.Controls.Add(this.CreateAlbumButton);
            this.AlbumsTab.Controls.Add(this.FetchAlbumsButton);
            this.AlbumsTab.Controls.Add(this.AlbumsOrderCheckBox);
            this.AlbumsTab.Controls.Add(this.pictureBox5);
            this.AlbumsTab.Controls.Add(this.SelectedAlbumPictureBox);
            this.AlbumsTab.Controls.Add(this.AlbumsListBox);
            this.AlbumsTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AlbumsTab.Location = new System.Drawing.Point(4, 42);
            this.AlbumsTab.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumsTab.Name = "AlbumsTab";
            this.AlbumsTab.Size = new System.Drawing.Size(1232, 305);
            this.AlbumsTab.TabIndex = 5;
            this.AlbumsTab.Text = "Albums";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(307, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 50);
            this.label5.TabIndex = 26;
            this.label5.Text = "Press on album name from list to see details";
            // 
            // AlbumDescriptionTextBox
            // 
            this.AlbumDescriptionTextBox.Location = new System.Drawing.Point(20, 198);
            this.AlbumDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumDescriptionTextBox.Multiline = true;
            this.AlbumDescriptionTextBox.Name = "AlbumDescriptionTextBox";
            this.AlbumDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AlbumDescriptionTextBox.Size = new System.Drawing.Size(419, 88);
            this.AlbumDescriptionTextBox.TabIndex = 25;
            // 
            // AlbumDescriptionLabel
            // 
            this.AlbumDescriptionLabel.AutoSize = true;
            this.AlbumDescriptionLabel.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.AlbumDescriptionLabel.Location = new System.Drawing.Point(15, 170);
            this.AlbumDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlbumDescriptionLabel.Name = "AlbumDescriptionLabel";
            this.AlbumDescriptionLabel.Size = new System.Drawing.Size(116, 30);
            this.AlbumDescriptionLabel.TabIndex = 24;
            this.AlbumDescriptionLabel.Text = "Description:";
            // 
            // CreateAlbumLabel
            // 
            this.CreateAlbumLabel.AutoSize = true;
            this.CreateAlbumLabel.Font = new System.Drawing.Font("Segoe Print", 10F);
            this.CreateAlbumLabel.Location = new System.Drawing.Point(15, 130);
            this.CreateAlbumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CreateAlbumLabel.Name = "CreateAlbumLabel";
            this.CreateAlbumLabel.Size = new System.Drawing.Size(114, 30);
            this.CreateAlbumLabel.TabIndex = 23;
            this.CreateAlbumLabel.Text = "Created At:";
            // 
            // AlbumCreatedDateTimePicker
            // 
            this.AlbumCreatedDateTimePicker.Enabled = false;
            this.AlbumCreatedDateTimePicker.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumCreatedDateTimePicker.Location = new System.Drawing.Point(141, 128);
            this.AlbumCreatedDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumCreatedDateTimePicker.Name = "AlbumCreatedDateTimePicker";
            this.AlbumCreatedDateTimePicker.Size = new System.Drawing.Size(296, 36);
            this.AlbumCreatedDateTimePicker.TabIndex = 22;
            // 
            // CreateAlbumButton
            // 
            this.CreateAlbumButton.Location = new System.Drawing.Point(1081, 123);
            this.CreateAlbumButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateAlbumButton.Name = "CreateAlbumButton";
            this.CreateAlbumButton.Size = new System.Drawing.Size(120, 116);
            this.CreateAlbumButton.TabIndex = 9;
            this.CreateAlbumButton.Text = "Create New Album";
            this.CreateAlbumButton.UseVisualStyleBackColor = true;
            this.CreateAlbumButton.Click += new System.EventHandler(this.createAlbumButton_Click);
            // 
            // FetchAlbumsButton
            // 
            this.FetchAlbumsButton.Location = new System.Drawing.Point(1081, 68);
            this.FetchAlbumsButton.Margin = new System.Windows.Forms.Padding(4);
            this.FetchAlbumsButton.Name = "FetchAlbumsButton";
            this.FetchAlbumsButton.Size = new System.Drawing.Size(120, 48);
            this.FetchAlbumsButton.TabIndex = 8;
            this.FetchAlbumsButton.Text = "Fetch";
            this.FetchAlbumsButton.UseVisualStyleBackColor = true;
            this.FetchAlbumsButton.Click += new System.EventHandler(this.fetchAlbumsButton_Click);
            // 
            // AlbumsOrderCheckBox
            // 
            this.AlbumsOrderCheckBox.AutoSize = true;
            this.AlbumsOrderCheckBox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsOrderCheckBox.Location = new System.Drawing.Point(1081, 23);
            this.AlbumsOrderCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumsOrderCheckBox.Name = "AlbumsOrderCheckBox";
            this.AlbumsOrderCheckBox.Size = new System.Drawing.Size(118, 37);
            this.AlbumsOrderCheckBox.TabIndex = 7;
            this.AlbumsOrderCheckBox.Text = "In order";
            this.AlbumsOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::MyFacebookApp.Properties.Resources.Info;
            this.pictureBox5.Location = new System.Drawing.Point(280, 21);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // SelectedAlbumPictureBox
            // 
            this.SelectedAlbumPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SelectedAlbumPictureBox.Image = global::MyFacebookApp.Properties.Resources.album;
            this.SelectedAlbumPictureBox.Location = new System.Drawing.Point(20, 11);
            this.SelectedAlbumPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.SelectedAlbumPictureBox.Name = "SelectedAlbumPictureBox";
            this.SelectedAlbumPictureBox.Size = new System.Drawing.Size(129, 105);
            this.SelectedAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SelectedAlbumPictureBox.TabIndex = 21;
            this.SelectedAlbumPictureBox.TabStop = false;
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.ItemHeight = 26;
            this.AlbumsListBox.Location = new System.Drawing.Point(463, 23);
            this.AlbumsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(609, 238);
            this.AlbumsListBox.TabIndex = 6;
            this.AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // PostsTab
            // 
            this.PostsTab.BackColor = System.Drawing.Color.Snow;
            this.PostsTab.Controls.Add(this.FetchPostsButton);
            this.PostsTab.Controls.Add(this.PostsListBox);
            this.PostsTab.Location = new System.Drawing.Point(4, 42);
            this.PostsTab.Margin = new System.Windows.Forms.Padding(4);
            this.PostsTab.Name = "PostsTab";
            this.PostsTab.Size = new System.Drawing.Size(1232, 305);
            this.PostsTab.TabIndex = 2;
            this.PostsTab.Text = "Posts";
            // 
            // FetchPostsButton
            // 
            this.FetchPostsButton.ForeColor = System.Drawing.Color.MediumPurple;
            this.FetchPostsButton.Location = new System.Drawing.Point(28, 26);
            this.FetchPostsButton.Margin = new System.Windows.Forms.Padding(4);
            this.FetchPostsButton.Name = "FetchPostsButton";
            this.FetchPostsButton.Size = new System.Drawing.Size(100, 38);
            this.FetchPostsButton.TabIndex = 7;
            this.FetchPostsButton.Text = "Fetch";
            this.FetchPostsButton.UseVisualStyleBackColor = true;
            this.FetchPostsButton.Click += new System.EventHandler(this.fetchPostsButton_Click);
            // 
            // PostsListBox
            // 
            this.PostsListBox.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.PostsListBox.ForeColor = System.Drawing.Color.Purple;
            this.PostsListBox.FormattingEnabled = true;
            this.PostsListBox.ItemHeight = 28;
            this.PostsListBox.Location = new System.Drawing.Point(136, 26);
            this.PostsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.PostsListBox.Name = "PostsListBox";
            this.PostsListBox.Size = new System.Drawing.Size(1032, 256);
            this.PostsListBox.TabIndex = 6;
            // 
            // FriendListTab
            // 
            this.FriendListTab.BackColor = System.Drawing.Color.Snow;
            this.FriendListTab.Controls.Add(this.label3);
            this.FriendListTab.Controls.Add(this.FriendsLastNameOrderCheckBox);
            this.FriendListTab.Controls.Add(this.FetchFriendButton);
            this.FriendListTab.Controls.Add(this.FriendsFirstNameOrderCheckBox);
            this.FriendListTab.Controls.Add(this.pictureBox3);
            this.FriendListTab.Controls.Add(this.FriendCheckedPictureBox);
            this.FriendListTab.Controls.Add(this.FriendsListBox);
            this.FriendListTab.Location = new System.Drawing.Point(4, 42);
            this.FriendListTab.Margin = new System.Windows.Forms.Padding(4);
            this.FriendListTab.Name = "FriendListTab";
            this.FriendListTab.Padding = new System.Windows.Forms.Padding(4);
            this.FriendListTab.Size = new System.Drawing.Size(1232, 305);
            this.FriendListTab.TabIndex = 1;
            this.FriendListTab.Text = "Friend List";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label3.Location = new System.Drawing.Point(25, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 43);
            this.label3.TabIndex = 27;
            this.label3.Text = "Press on friend from list to see picture";
            // 
            // FriendsLastNameOrderCheckBox
            // 
            this.FriendsLastNameOrderCheckBox.AutoSize = true;
            this.FriendsLastNameOrderCheckBox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsLastNameOrderCheckBox.Location = new System.Drawing.Point(9, 53);
            this.FriendsLastNameOrderCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.FriendsLastNameOrderCheckBox.Name = "FriendsLastNameOrderCheckBox";
            this.FriendsLastNameOrderCheckBox.Size = new System.Drawing.Size(228, 37);
            this.FriendsLastNameOrderCheckBox.TabIndex = 6;
            this.FriendsLastNameOrderCheckBox.Text = "Order by last name";
            this.FriendsLastNameOrderCheckBox.UseVisualStyleBackColor = true;
            this.FriendsLastNameOrderCheckBox.CheckedChanged += new System.EventHandler(this.friendsLastNameOrderCheckBox_CheckedChanged);
            // 
            // FetchFriendButton
            // 
            this.FetchFriendButton.Location = new System.Drawing.Point(136, 97);
            this.FetchFriendButton.Margin = new System.Windows.Forms.Padding(4);
            this.FetchFriendButton.Name = "FetchFriendButton";
            this.FetchFriendButton.Size = new System.Drawing.Size(113, 37);
            this.FetchFriendButton.TabIndex = 5;
            this.FetchFriendButton.Text = "Fetch";
            this.FetchFriendButton.UseVisualStyleBackColor = true;
            this.FetchFriendButton.Click += new System.EventHandler(this.fetchFriendButton_Click);
            // 
            // FriendsFirstNameOrderCheckBox
            // 
            this.FriendsFirstNameOrderCheckBox.AutoSize = true;
            this.FriendsFirstNameOrderCheckBox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsFirstNameOrderCheckBox.Location = new System.Drawing.Point(9, 18);
            this.FriendsFirstNameOrderCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.FriendsFirstNameOrderCheckBox.Name = "FriendsFirstNameOrderCheckBox";
            this.FriendsFirstNameOrderCheckBox.Size = new System.Drawing.Size(235, 37);
            this.FriendsFirstNameOrderCheckBox.TabIndex = 4;
            this.FriendsFirstNameOrderCheckBox.Text = "Order by first name";
            this.FriendsFirstNameOrderCheckBox.UseVisualStyleBackColor = true;
            this.FriendsFirstNameOrderCheckBox.CheckedChanged += new System.EventHandler(this.friendsFirstNameOrderCheckBox_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::MyFacebookApp.Properties.Resources.Info;
            this.pictureBox3.Location = new System.Drawing.Point(4, 343);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // FriendCheckedPictureBox
            // 
            this.FriendCheckedPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.FriendCheckedPictureBox.Image = global::MyFacebookApp.Properties.Resources.friend;
            this.FriendCheckedPictureBox.Location = new System.Drawing.Point(1071, 22);
            this.FriendCheckedPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.FriendCheckedPictureBox.Name = "FriendCheckedPictureBox";
            this.FriendCheckedPictureBox.Size = new System.Drawing.Size(119, 128);
            this.FriendCheckedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FriendCheckedPictureBox.TabIndex = 10;
            this.FriendCheckedPictureBox.TabStop = false;
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.ItemHeight = 28;
            this.FriendsListBox.Location = new System.Drawing.Point(264, 23);
            this.FriendsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(785, 256);
            this.FriendsListBox.TabIndex = 3;
            this.FriendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // LikedPagesTab
            // 
            this.LikedPagesTab.BackColor = System.Drawing.Color.Snow;
            this.LikedPagesTab.Controls.Add(this.label4);
            this.LikedPagesTab.Controls.Add(this.FetchLikedPagesButton);
            this.LikedPagesTab.Controls.Add(this.LikedPagesInOrderCheckBox);
            this.LikedPagesTab.Controls.Add(this.pictureBox4);
            this.LikedPagesTab.Controls.Add(this.LikedPagePictureBox);
            this.LikedPagesTab.Controls.Add(this.LikedPagesListBox);
            this.LikedPagesTab.Location = new System.Drawing.Point(4, 42);
            this.LikedPagesTab.Margin = new System.Windows.Forms.Padding(4);
            this.LikedPagesTab.Name = "LikedPagesTab";
            this.LikedPagesTab.Size = new System.Drawing.Size(1232, 305);
            this.LikedPagesTab.TabIndex = 4;
            this.LikedPagesTab.Text = "Liked Pages";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.5F);
            this.label4.Location = new System.Drawing.Point(1079, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 64);
            this.label4.TabIndex = 29;
            this.label4.Text = "Press on page from list to see picture";
            // 
            // FetchLikedPagesButton
            // 
            this.FetchLikedPagesButton.Location = new System.Drawing.Point(47, 69);
            this.FetchLikedPagesButton.Margin = new System.Windows.Forms.Padding(4);
            this.FetchLikedPagesButton.Name = "FetchLikedPagesButton";
            this.FetchLikedPagesButton.Size = new System.Drawing.Size(88, 38);
            this.FetchLikedPagesButton.TabIndex = 5;
            this.FetchLikedPagesButton.Text = "Fetch";
            this.FetchLikedPagesButton.UseVisualStyleBackColor = true;
            this.FetchLikedPagesButton.Click += new System.EventHandler(this.fetchLikedPagesButton_Click);
            // 
            // LikedPagesInOrderCheckBox
            // 
            this.LikedPagesInOrderCheckBox.AutoSize = true;
            this.LikedPagesInOrderCheckBox.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LikedPagesInOrderCheckBox.Location = new System.Drawing.Point(21, 25);
            this.LikedPagesInOrderCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.LikedPagesInOrderCheckBox.Name = "LikedPagesInOrderCheckBox";
            this.LikedPagesInOrderCheckBox.Size = new System.Drawing.Size(118, 37);
            this.LikedPagesInOrderCheckBox.TabIndex = 4;
            this.LikedPagesInOrderCheckBox.Text = "In order";
            this.LikedPagesInOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::MyFacebookApp.Properties.Resources.Info;
            this.pictureBox4.Location = new System.Drawing.Point(1052, 239);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // LikedPagePictureBox
            // 
            this.LikedPagePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LikedPagePictureBox.Image = global::MyFacebookApp.Properties.Resources.page;
            this.LikedPagePictureBox.Location = new System.Drawing.Point(1072, 32);
            this.LikedPagePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.LikedPagePictureBox.Name = "LikedPagePictureBox";
            this.LikedPagePictureBox.Size = new System.Drawing.Size(105, 114);
            this.LikedPagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LikedPagePictureBox.TabIndex = 11;
            this.LikedPagePictureBox.TabStop = false;
            // 
            // LikedPagesListBox
            // 
            this.LikedPagesListBox.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.LikedPagesListBox.FormattingEnabled = true;
            this.LikedPagesListBox.ItemHeight = 28;
            this.LikedPagesListBox.Location = new System.Drawing.Point(155, 32);
            this.LikedPagesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.LikedPagesListBox.Name = "LikedPagesListBox";
            this.LikedPagesListBox.Size = new System.Drawing.Size(884, 256);
            this.LikedPagesListBox.TabIndex = 3;
            this.LikedPagesListBox.SelectedIndexChanged += new System.EventHandler(this.likedPagesListBox_SelectedIndexChanged);
            // 
            // GetInTouchTab
            // 
            this.GetInTouchTab.BackColor = System.Drawing.Color.White;
            this.GetInTouchTab.Controls.Add(this.label2);
            this.GetInTouchTab.Controls.Add(this.pictureBox2);
            this.GetInTouchTab.Controls.Add(this.GetInThouchPictureBox);
            this.GetInTouchTab.Controls.Add(this.Hearts2PictureBox);
            this.GetInTouchTab.Controls.Add(this.HeartsPictureBox);
            this.GetInTouchTab.Controls.Add(this.SingelsFriendsListBox);
            this.GetInTouchTab.Controls.Add(this.FetchSingelsFriendsButton);
            this.GetInTouchTab.Controls.Add(this.GenderComboBox);
            this.GetInTouchTab.Controls.Add(this.GenderLabel);
            this.GetInTouchTab.Location = new System.Drawing.Point(4, 42);
            this.GetInTouchTab.Margin = new System.Windows.Forms.Padding(4);
            this.GetInTouchTab.Name = "GetInTouchTab";
            this.GetInTouchTab.Size = new System.Drawing.Size(1232, 305);
            this.GetInTouchTab.TabIndex = 7;
            this.GetInTouchTab.Text = "Get In Touch";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.label2.Location = new System.Drawing.Point(1083, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 76);
            this.label2.TabIndex = 25;
            this.label2.Text = "Press on friend from list to see picture";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MyFacebookApp.Properties.Resources.Info;
            this.pictureBox2.Location = new System.Drawing.Point(1059, 235);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // GetInThouchPictureBox
            // 
            this.GetInThouchPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.GetInThouchPictureBox.Image = global::MyFacebookApp.Properties.Resources.singleFriend;
            this.GetInThouchPictureBox.Location = new System.Drawing.Point(1067, 89);
            this.GetInThouchPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.GetInThouchPictureBox.Name = "GetInThouchPictureBox";
            this.GetInThouchPictureBox.Size = new System.Drawing.Size(97, 116);
            this.GetInThouchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GetInThouchPictureBox.TabIndex = 11;
            this.GetInThouchPictureBox.TabStop = false;
            // 
            // Hearts2PictureBox
            // 
            this.Hearts2PictureBox.Image = global::MyFacebookApp.Properties.Resources.hearts;
            this.Hearts2PictureBox.Location = new System.Drawing.Point(63, 7);
            this.Hearts2PictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.Hearts2PictureBox.Name = "Hearts2PictureBox";
            this.Hearts2PictureBox.Size = new System.Drawing.Size(81, 74);
            this.Hearts2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hearts2PictureBox.TabIndex = 9;
            this.Hearts2PictureBox.TabStop = false;
            // 
            // HeartsPictureBox
            // 
            this.HeartsPictureBox.Image = global::MyFacebookApp.Properties.Resources.hearts;
            this.HeartsPictureBox.Location = new System.Drawing.Point(936, 7);
            this.HeartsPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.HeartsPictureBox.Name = "HeartsPictureBox";
            this.HeartsPictureBox.Size = new System.Drawing.Size(81, 74);
            this.HeartsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HeartsPictureBox.TabIndex = 8;
            this.HeartsPictureBox.TabStop = false;
            // 
            // SingelsFriendsListBox
            // 
            this.SingelsFriendsListBox.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.SingelsFriendsListBox.ForeColor = System.Drawing.Color.Red;
            this.SingelsFriendsListBox.FormattingEnabled = true;
            this.SingelsFriendsListBox.ItemHeight = 28;
            this.SingelsFriendsListBox.Location = new System.Drawing.Point(40, 89);
            this.SingelsFriendsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.SingelsFriendsListBox.Name = "SingelsFriendsListBox";
            this.SingelsFriendsListBox.Size = new System.Drawing.Size(1004, 200);
            this.SingelsFriendsListBox.TabIndex = 7;
            this.SingelsFriendsListBox.SelectedIndexChanged += new System.EventHandler(this.singelsFriendsListBox_SelectedIndexChanged);
            // 
            // FetchSingelsFriendsButton
            // 
            this.FetchSingelsFriendsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FetchSingelsFriendsButton.Font = new System.Drawing.Font("Segoe Print", 12.75F);
            this.FetchSingelsFriendsButton.ForeColor = System.Drawing.Color.DarkRed;
            this.FetchSingelsFriendsButton.Location = new System.Drawing.Point(621, 16);
            this.FetchSingelsFriendsButton.Margin = new System.Windows.Forms.Padding(4);
            this.FetchSingelsFriendsButton.Name = "FetchSingelsFriendsButton";
            this.FetchSingelsFriendsButton.Size = new System.Drawing.Size(296, 49);
            this.FetchSingelsFriendsButton.TabIndex = 2;
            this.FetchSingelsFriendsButton.Text = "Get singels friend list!";
            this.FetchSingelsFriendsButton.UseVisualStyleBackColor = false;
            this.FetchSingelsFriendsButton.Click += new System.EventHandler(this.fetchSingelsFriendsButton_Click);
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.AllowDrop = true;
            this.GenderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.GenderComboBox.Location = new System.Drawing.Point(455, 22);
            this.GenderComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(160, 41);
            this.GenderComboBox.TabIndex = 1;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GenderLabel.Location = new System.Drawing.Point(149, 28);
            this.GenderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(291, 33);
            this.GenderLabel.TabIndex = 0;
            this.GenderLabel.Text = "Choose your desired gender:";
            // 
            // UserBirthdayLabel
            // 
            this.UserBirthdayLabel.AutoSize = true;
            this.UserBirthdayLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.UserBirthdayLabel.ForeColor = System.Drawing.Color.Black;
            this.UserBirthdayLabel.Location = new System.Drawing.Point(141, 316);
            this.UserBirthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserBirthdayLabel.Name = "UserBirthdayLabel";
            this.UserBirthdayLabel.Size = new System.Drawing.Size(28, 24);
            this.UserBirthdayLabel.TabIndex = 4;
            this.UserBirthdayLabel.Text = " ...";
            // 
            // UserEmailLabel
            // 
            this.UserEmailLabel.AutoSize = true;
            this.UserEmailLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.UserEmailLabel.ForeColor = System.Drawing.Color.Black;
            this.UserEmailLabel.Location = new System.Drawing.Point(147, 420);
            this.UserEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserEmailLabel.Name = "UserEmailLabel";
            this.UserEmailLabel.Size = new System.Drawing.Size(22, 24);
            this.UserEmailLabel.TabIndex = 5;
            this.UserEmailLabel.Text = "...";
            // 
            // UserLivesInLabel
            // 
            this.UserLivesInLabel.AutoSize = true;
            this.UserLivesInLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.UserLivesInLabel.ForeColor = System.Drawing.Color.Black;
            this.UserLivesInLabel.Location = new System.Drawing.Point(147, 341);
            this.UserLivesInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserLivesInLabel.Name = "UserLivesInLabel";
            this.UserLivesInLabel.Size = new System.Drawing.Size(22, 24);
            this.UserLivesInLabel.TabIndex = 6;
            this.UserLivesInLabel.Text = "...";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe Print", 9.75F);
            this.StatusLabel.Location = new System.Drawing.Point(473, 292);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(204, 30);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "What\'s on your mind?";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StatusTextBox.Location = new System.Drawing.Point(479, 319);
            this.StatusTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(388, 32);
            this.StatusTextBox.TabIndex = 8;
            // 
            // PostStatusButton
            // 
            this.PostStatusButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PostStatusButton.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.PostStatusButton.Location = new System.Drawing.Point(769, 359);
            this.PostStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.PostStatusButton.Name = "PostStatusButton";
            this.PostStatusButton.Size = new System.Drawing.Size(99, 33);
            this.PostStatusButton.TabIndex = 9;
            this.PostStatusButton.Text = "Post";
            this.PostStatusButton.UseVisualStyleBackColor = false;
            this.PostStatusButton.Click += new System.EventHandler(this.postStatusButton_Click);
            // 
            // UserInterestedInLabel
            // 
            this.UserInterestedInLabel.AutoSize = true;
            this.UserInterestedInLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.UserInterestedInLabel.ForeColor = System.Drawing.Color.Black;
            this.UserInterestedInLabel.Location = new System.Drawing.Point(147, 367);
            this.UserInterestedInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserInterestedInLabel.Name = "UserInterestedInLabel";
            this.UserInterestedInLabel.Size = new System.Drawing.Size(22, 24);
            this.UserInterestedInLabel.TabIndex = 11;
            this.UserInterestedInLabel.Text = "...";
            // 
            // UserGenderLabel
            // 
            this.UserGenderLabel.AutoSize = true;
            this.UserGenderLabel.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.UserGenderLabel.ForeColor = System.Drawing.Color.Black;
            this.UserGenderLabel.Location = new System.Drawing.Point(147, 393);
            this.UserGenderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserGenderLabel.Name = "UserGenderLabel";
            this.UserGenderLabel.Size = new System.Drawing.Size(22, 24);
            this.UserGenderLabel.TabIndex = 12;
            this.UserGenderLabel.Text = "...";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimeLabel.Location = new System.Drawing.Point(1083, 248);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(45, 20);
            this.TimeLabel.TabIndex = 13;
            this.TimeLabel.Text = "Time:";
            // 
            // UiDateHLabel
            // 
            this.UiDateHLabel.AutoSize = true;
            this.UiDateHLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UiDateHLabel.Location = new System.Drawing.Point(1083, 269);
            this.UiDateHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UiDateHLabel.Name = "UiDateHLabel";
            this.UiDateHLabel.Size = new System.Drawing.Size(44, 20);
            this.UiDateHLabel.TabIndex = 14;
            this.UiDateHLabel.Text = "Date:";
            // 
            // TimeUILabel
            // 
            this.TimeUILabel.AutoSize = true;
            this.TimeUILabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimeUILabel.Location = new System.Drawing.Point(1129, 248);
            this.TimeUILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeUILabel.Name = "TimeUILabel";
            this.TimeUILabel.Size = new System.Drawing.Size(18, 20);
            this.TimeUILabel.TabIndex = 15;
            this.TimeUILabel.Text = "...";
            // 
            // DateUiLabel
            // 
            this.DateUiLabel.AutoSize = true;
            this.DateUiLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateUiLabel.Location = new System.Drawing.Point(1129, 269);
            this.DateUiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateUiLabel.Name = "DateUiLabel";
            this.DateUiLabel.Size = new System.Drawing.Size(18, 20);
            this.DateUiLabel.TabIndex = 16;
            this.DateUiLabel.Text = "...";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 393);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gender: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 367);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Interested in:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 341);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lives In: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 420);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Email:";
            // 
            // HBIrthdayLlabel
            // 
            this.HBIrthdayLlabel.AutoSize = true;
            this.HBIrthdayLlabel.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HBIrthdayLlabel.Location = new System.Drawing.Point(25, 316);
            this.HBIrthdayLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HBIrthdayLlabel.Name = "HBIrthdayLlabel";
            this.HBIrthdayLlabel.Size = new System.Drawing.Size(83, 26);
            this.HBIrthdayLlabel.TabIndex = 17;
            this.HBIrthdayLlabel.Text = "Birthday:";
            // 
            // UserProfilePictureBox
            // 
            this.UserProfilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UserProfilePictureBox.Location = new System.Drawing.Point(23, 158);
            this.UserProfilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserProfilePictureBox.Name = "UserProfilePictureBox";
            this.UserProfilePictureBox.Size = new System.Drawing.Size(153, 142);
            this.UserProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserProfilePictureBox.TabIndex = 0;
            this.UserProfilePictureBox.TabStop = false;
            // 
            // CoverPictureBox
            // 
            this.CoverPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.CoverPictureBox.Location = new System.Drawing.Point(3, -1);
            this.CoverPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.CoverPictureBox.Name = "CoverPictureBox";
            this.CoverPictureBox.Size = new System.Drawing.Size(1237, 245);
            this.CoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CoverPictureBox.TabIndex = 10;
            this.CoverPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1241, 818);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.HBIrthdayLlabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.DateUiLabel);
            this.Controls.Add(this.TimeUILabel);
            this.Controls.Add(this.UiDateHLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.UserGenderLabel);
            this.Controls.Add(this.UserInterestedInLabel);
            this.Controls.Add(this.UserLivesInLabel);
            this.Controls.Add(this.UserEmailLabel);
            this.Controls.Add(this.UserBirthdayLabel);
            this.Controls.Add(this.UserProfilePictureBox);
            this.Controls.Add(this.PostStatusButton);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.UserTabControl);
            this.Controls.Add(this.CoverPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "My Facebook Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.UserTabControl.ResumeLayout(false);
            this.EventsTab.ResumeLayout(false);
            this.EventsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.EventsGroupBox.ResumeLayout(false);
            this.EventsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedEventPictureBox)).EndInit();
            this.CheckInsTab.ResumeLayout(false);
            this.HoroscopeTab.ResumeLayout(false);
            this.HoroscopeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignPictureBox)).EndInit();
            this.PlaylistTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notes1PictureBox)).EndInit();
            this.AlbumsTab.ResumeLayout(false);
            this.AlbumsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedAlbumPictureBox)).EndInit();
            this.PostsTab.ResumeLayout(false);
            this.FriendListTab.ResumeLayout(false);
            this.FriendListTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendCheckedPictureBox)).EndInit();
            this.LikedPagesTab.ResumeLayout(false);
            this.LikedPagesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LikedPagePictureBox)).EndInit();
            this.GetInTouchTab.ResumeLayout(false);
            this.GetInTouchTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetInThouchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hearts2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeartsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UserProfilePictureBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TabControl UserTabControl;
        private System.Windows.Forms.TabPage EventsTab;
        private System.Windows.Forms.TabPage FriendListTab;
        private System.Windows.Forms.TabPage PostsTab;
        private System.Windows.Forms.TabPage CheckInsTab;
        private System.Windows.Forms.TabPage LikedPagesTab;
        private System.Windows.Forms.TabPage AlbumsTab;
        private System.Windows.Forms.TabPage HoroscopeTab;
        private System.Windows.Forms.TabPage GetInTouchTab;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.Label UserBirthdayLabel;
        private System.Windows.Forms.Label UserEmailLabel;
        private System.Windows.Forms.Label UserLivesInLabel;
        private System.Windows.Forms.CheckBox FriendsLastNameOrderCheckBox;
        private System.Windows.Forms.Button FetchFriendButton;
        private System.Windows.Forms.CheckBox FriendsFirstNameOrderCheckBox;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.Button FetchPostsButton;
        private System.Windows.Forms.ListBox PostsListBox;
        private System.Windows.Forms.Button FetchCheckInsButton;
        private System.Windows.Forms.ListBox CheckInsListBox;
        private System.Windows.Forms.Button FetchLikedPagesButton;
        private System.Windows.Forms.CheckBox LikedPagesInOrderCheckBox;
        private System.Windows.Forms.ListBox LikedPagesListBox;
        private System.Windows.Forms.Button FetchAlbumsButton;
        private System.Windows.Forms.CheckBox AlbumsOrderCheckBox;
        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.Label ZodiacSignLabel;
        private System.Windows.Forms.TextBox HoroscopeTextBox;
        private System.Windows.Forms.Label HoroscopeBirthdayLabel;
        private System.Windows.Forms.ListBox SingelsFriendsListBox;
        private System.Windows.Forms.Button FetchSingelsFriendsButton;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Button PostStatusButton;
        private System.Windows.Forms.PictureBox FriendCheckedPictureBox;
        private System.Windows.Forms.Button FetchHoroscopeButton;
        private System.Windows.Forms.PictureBox HeartsPictureBox;
        private System.Windows.Forms.PictureBox Hearts2PictureBox;
        private System.Windows.Forms.Button CreateAlbumButton;
        private System.Windows.Forms.Button ShowCheckInsButton;
        private System.Windows.Forms.TabPage PlaylistTabPage;
        private System.Windows.Forms.PictureBox Notes1PictureBox;
        private System.Windows.Forms.Button GetPlaylistButton;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox LikedPagePictureBox;
        private System.Windows.Forms.PictureBox GetInThouchPictureBox;
        private System.Windows.Forms.PictureBox SelectedEventPictureBox;
        private System.Windows.Forms.TextBox EventDescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.Label OwnerNameLabel;
        private System.Windows.Forms.Label Ownerlabel;
        private System.Windows.Forms.PictureBox SignPictureBox;
        private System.Windows.Forms.Button SelectsPartnerButton;
        private System.Windows.Forms.Button GetMathcesButton;
        private System.Windows.Forms.GroupBox EventsGroupBox;
        private System.Windows.Forms.RadioButton NotRepliedRadioButton;
        private System.Windows.Forms.RadioButton AttendingRadioButton;
        private System.Windows.Forms.RadioButton MaybeRadioButton;
        private System.Windows.Forms.RadioButton NotAttendingRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox AlbumDescriptionTextBox;
        private System.Windows.Forms.Label AlbumDescriptionLabel;
        private System.Windows.Forms.Label CreateAlbumLabel;
        private System.Windows.Forms.DateTimePicker AlbumCreatedDateTimePicker;
        private System.Windows.Forms.PictureBox SelectedAlbumPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox CoverPictureBox;
        private System.Windows.Forms.Label UserInterestedInLabel;
        private System.Windows.Forms.Label UserGenderLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label UiDateHLabel;
        private System.Windows.Forms.Label TimeUILabel;
        private System.Windows.Forms.Label DateUiLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label HBIrthdayLlabel;
    }
}