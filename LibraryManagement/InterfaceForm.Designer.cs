namespace LibraryManagement
{
    partial class InterfaceForm
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.vilniusUniversityBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet1 = new LibraryManagement.LibraryDataSet1();
            this.contactDataSet = new LibraryManagement.ContactDataSet();
            this.vilniusUniversityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Vilnius_University__TableAdapter = new LibraryManagement.ContactDataSetTableAdapters._Vilnius_University__TableAdapter();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.libraryDataSet = new LibraryManagement.LibraryDataSet();
            this.vilniusUniversityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._Vilnius_University__TableAdapter1 = new LibraryManagement.LibraryDataSetTableAdapters._Vilnius_University__TableAdapter();
            this._Vilnius_University__TableAdapter2 = new LibraryManagement.LibraryDataSet1TableAdapters._Vilnius_University__TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vilniusUniversityBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vilniusUniversityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vilniusUniversityBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(314, 65);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(75, 25);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            // 
            // UserDGV
            // 
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDGV.Location = new System.Drawing.Point(12, 109);
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.ReadOnly = true;
            this.UserDGV.RowHeadersWidth = 51;
            this.UserDGV.RowTemplate.Height = 24;
            this.UserDGV.Size = new System.Drawing.Size(1256, 563);
            this.UserDGV.TabIndex = 1;
            // 
            // vilniusUniversityBindingSource2
            // 
            this.vilniusUniversityBindingSource2.DataMember = "\'Vilnius University$\'";
            this.vilniusUniversityBindingSource2.DataSource = this.libraryDataSet1;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet1";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactDataSet
            // 
            this.contactDataSet.DataSetName = "ContactDataSet";
            this.contactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vilniusUniversityBindingSource
            // 
            this.vilniusUniversityBindingSource.DataMember = "\'Vilnius University$\'";
            this.vilniusUniversityBindingSource.DataSource = this.contactDataSet;
            // 
            // _Vilnius_University__TableAdapter
            // 
            this._Vilnius_University__TableAdapter.ClearBeforeFill = true;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(395, 60);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(585, 30);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vilniusUniversityBindingSource1
            // 
            this.vilniusUniversityBindingSource1.DataMember = "\'Vilnius University$\'";
            this.vilniusUniversityBindingSource1.DataSource = this.libraryDataSet;
            // 
            // _Vilnius_University__TableAdapter1
            // 
            this._Vilnius_University__TableAdapter1.ClearBeforeFill = true;
            // 
            // _Vilnius_University__TableAdapter2
            // 
            this._Vilnius_University__TableAdapter2.ClearBeforeFill = true;
            // 
            // InterfaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.UserDGV);
            this.Controls.Add(this.searchLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfaceForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InterfaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vilniusUniversityBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vilniusUniversityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vilniusUniversityBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView UserDGV;
        private ContactDataSet contactDataSet;
        private System.Windows.Forms.BindingSource vilniusUniversityBindingSource;
        private ContactDataSetTableAdapters._Vilnius_University__TableAdapter _Vilnius_University__TableAdapter;
        private System.Windows.Forms.TextBox searchBox;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource vilniusUniversityBindingSource1;
        private LibraryDataSetTableAdapters._Vilnius_University__TableAdapter _Vilnius_University__TableAdapter1;
        private LibraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource vilniusUniversityBindingSource2;
        private LibraryDataSet1TableAdapters._Vilnius_University__TableAdapter _Vilnius_University__TableAdapter2;
    }
}