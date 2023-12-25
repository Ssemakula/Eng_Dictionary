﻿namespace Eng_Dictionary
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchItemLable = new System.Windows.Forms.Label();
            this.searchItemTextBox = new System.Windows.Forms.TextBox();
            this.searchItemButton = new System.Windows.Forms.Button();
            this.similarCheckBox = new System.Windows.Forms.CheckBox();
            this.itemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.eng_dict_ds = new Eng_Dictionary.Datasets.eng_dict_ds();
            this.enwordlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.en_word_listTableAdapter = new Eng_Dictionary.Datasets.eng_dict_dsTableAdapters.en_word_listTableAdapter();
            this.wordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingNavigator)).BeginInit();
            this.itemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eng_dict_ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enwordlistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.similarCheckBox);
            this.searchGroupBox.Controls.Add(this.searchItemButton);
            this.searchGroupBox.Controls.Add(this.searchItemTextBox);
            this.searchGroupBox.Controls.Add(this.searchItemLable);
            this.searchGroupBox.Location = new System.Drawing.Point(12, 32);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(531, 115);
            this.searchGroupBox.TabIndex = 0;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search Information";
            // 
            // searchItemLable
            // 
            this.searchItemLable.Location = new System.Drawing.Point(22, 37);
            this.searchItemLable.Name = "searchItemLable";
            this.searchItemLable.Size = new System.Drawing.Size(103, 24);
            this.searchItemLable.TabIndex = 0;
            this.searchItemLable.Text = "Search by";
            this.searchItemLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchItemTextBox
            // 
            this.searchItemTextBox.Location = new System.Drawing.Point(125, 37);
            this.searchItemTextBox.Name = "searchItemTextBox";
            this.searchItemTextBox.Size = new System.Drawing.Size(290, 21);
            this.searchItemTextBox.TabIndex = 1;
            // 
            // searchItemButton
            // 
            this.searchItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchItemButton.Image = global::Eng_Dictionary.Properties.Resources.search_memo;
            this.searchItemButton.Location = new System.Drawing.Point(421, 27);
            this.searchItemButton.Name = "searchItemButton";
            this.searchItemButton.Size = new System.Drawing.Size(94, 40);
            this.searchItemButton.TabIndex = 2;
            this.searchItemButton.Text = "Search";
            this.searchItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchItemButton.UseVisualStyleBackColor = true;
            // 
            // similarCheckBox
            // 
            this.similarCheckBox.AutoSize = true;
            this.similarCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.similarCheckBox.Location = new System.Drawing.Point(125, 68);
            this.similarCheckBox.Name = "similarCheckBox";
            this.similarCheckBox.Size = new System.Drawing.Size(101, 19);
            this.similarCheckBox.TabIndex = 3;
            this.similarCheckBox.Text = "Similar words";
            this.similarCheckBox.UseVisualStyleBackColor = true;
            // 
            // itemBindingNavigator
            // 
            this.itemBindingNavigator.AddNewItem = null;
            this.itemBindingNavigator.BindingSource = this.enwordlistBindingSource;
            this.itemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemBindingNavigator.DeleteItem = null;
            this.itemBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.itemBindingNavigator.Location = new System.Drawing.Point(0, 466);
            this.itemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemBindingNavigator.Name = "itemBindingNavigator";
            this.itemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemBindingNavigator.Size = new System.Drawing.Size(650, 25);
            this.itemBindingNavigator.TabIndex = 1;
            this.itemBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.itemDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordDataGridViewTextBoxColumn,
            this.wordtypeDataGridViewTextBoxColumn,
            this.definitionDataGridViewTextBoxColumn});
            this.itemDataGridView.DataSource = this.enwordlistBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(13, 154);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.ReadOnly = true;
            this.itemDataGridView.RowHeadersWidth = 25;
            this.itemDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.itemDataGridView.Size = new System.Drawing.Size(625, 299);
            this.itemDataGridView.TabIndex = 2;
            // 
            // eng_dict_ds
            // 
            this.eng_dict_ds.DataSetName = "eng_dict_ds";
            this.eng_dict_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // enwordlistBindingSource
            // 
            this.enwordlistBindingSource.DataMember = "en_word_list";
            this.enwordlistBindingSource.DataSource = this.eng_dict_ds;
            // 
            // en_word_listTableAdapter
            // 
            this.en_word_listTableAdapter.ClearBeforeFill = true;
            // 
            // wordDataGridViewTextBoxColumn
            // 
            this.wordDataGridViewTextBoxColumn.DataPropertyName = "word";
            this.wordDataGridViewTextBoxColumn.HeaderText = "Word";
            this.wordDataGridViewTextBoxColumn.Name = "wordDataGridViewTextBoxColumn";
            this.wordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wordtypeDataGridViewTextBoxColumn
            // 
            this.wordtypeDataGridViewTextBoxColumn.DataPropertyName = "wordtype";
            this.wordtypeDataGridViewTextBoxColumn.HeaderText = "Word Type";
            this.wordtypeDataGridViewTextBoxColumn.Name = "wordtypeDataGridViewTextBoxColumn";
            this.wordtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // definitionDataGridViewTextBoxColumn
            // 
            this.definitionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.definitionDataGridViewTextBoxColumn.DataPropertyName = "definition";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.definitionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.definitionDataGridViewTextBoxColumn.HeaderText = "Definition";
            this.definitionDataGridViewTextBoxColumn.Name = "definitionDataGridViewTextBoxColumn";
            this.definitionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 491);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.itemBindingNavigator);
            this.Controls.Add(this.searchGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingNavigator)).EndInit();
            this.itemBindingNavigator.ResumeLayout(false);
            this.itemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eng_dict_ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enwordlistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.CheckBox similarCheckBox;
        private System.Windows.Forms.Button searchItemButton;
        private System.Windows.Forms.TextBox searchItemTextBox;
        private System.Windows.Forms.Label searchItemLable;
        private System.Windows.Forms.BindingNavigator itemBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private Datasets.eng_dict_ds eng_dict_ds;
        private System.Windows.Forms.BindingSource enwordlistBindingSource;
        private Datasets.eng_dict_dsTableAdapters.en_word_listTableAdapter en_word_listTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionDataGridViewTextBoxColumn;
    }
}