namespace ZH2_UWRH74
{
    partial class FormLesson
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonSkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructorFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomFkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 364);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hozzáadás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(138, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 364);
            this.listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(264, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 364);
            this.listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            this.listBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new System.Drawing.Point(390, 12);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 364);
            this.listBox4.TabIndex = 8;
            // 
            // listBox5
            // 
            this.listBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 15;
            this.listBox5.Location = new System.Drawing.Point(516, 12);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(120, 364);
            this.listBox5.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lessonSkDataGridViewTextBoxColumn,
            this.courseFkDataGridViewTextBoxColumn,
            this.instructorFkDataGridViewTextBoxColumn,
            this.dayFkDataGridViewTextBoxColumn,
            this.timeFkDataGridViewTextBoxColumn,
            this.roomFkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(642, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(545, 364);
            this.dataGridView1.TabIndex = 10;
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataSource = typeof(ZH2_UWRH74.Models.Lesson);
            // 
            // lessonSkDataGridViewTextBoxColumn
            // 
            this.lessonSkDataGridViewTextBoxColumn.DataPropertyName = "LessonSk";
            this.lessonSkDataGridViewTextBoxColumn.HeaderText = "LessonSk";
            this.lessonSkDataGridViewTextBoxColumn.Name = "lessonSkDataGridViewTextBoxColumn";
            // 
            // courseFkDataGridViewTextBoxColumn
            // 
            this.courseFkDataGridViewTextBoxColumn.DataPropertyName = "CourseFk";
            this.courseFkDataGridViewTextBoxColumn.HeaderText = "CourseFk";
            this.courseFkDataGridViewTextBoxColumn.Name = "courseFkDataGridViewTextBoxColumn";
            // 
            // instructorFkDataGridViewTextBoxColumn
            // 
            this.instructorFkDataGridViewTextBoxColumn.DataPropertyName = "InstructorFk";
            this.instructorFkDataGridViewTextBoxColumn.HeaderText = "InstructorFk";
            this.instructorFkDataGridViewTextBoxColumn.Name = "instructorFkDataGridViewTextBoxColumn";
            // 
            // dayFkDataGridViewTextBoxColumn
            // 
            this.dayFkDataGridViewTextBoxColumn.DataPropertyName = "DayFk";
            this.dayFkDataGridViewTextBoxColumn.HeaderText = "DayFk";
            this.dayFkDataGridViewTextBoxColumn.Name = "dayFkDataGridViewTextBoxColumn";
            // 
            // timeFkDataGridViewTextBoxColumn
            // 
            this.timeFkDataGridViewTextBoxColumn.DataPropertyName = "TimeFk";
            this.timeFkDataGridViewTextBoxColumn.HeaderText = "TimeFk";
            this.timeFkDataGridViewTextBoxColumn.Name = "timeFkDataGridViewTextBoxColumn";
            // 
            // roomFkDataGridViewTextBoxColumn
            // 
            this.roomFkDataGridViewTextBoxColumn.DataPropertyName = "RoomFk";
            this.roomFkDataGridViewTextBoxColumn.HeaderText = "RoomFk";
            this.roomFkDataGridViewTextBoxColumn.Name = "roomFkDataGridViewTextBoxColumn";
            // 
            // FormLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 412);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormLesson";
            this.Text = "FormLesson";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn lessonSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn courseFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn instructorFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomFkDataGridViewTextBoxColumn;
        private BindingSource lessonBindingSource;
    }
}