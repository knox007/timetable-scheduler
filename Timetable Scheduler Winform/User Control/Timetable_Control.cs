﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetable_Data.Model;

namespace Timetable_Scheduler_Winform
{
    public partial class Timetable_Control : UserControl
    {
        public void Init_Table(DataGridView Table)
        {
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                Table.Columns.Add(new DataGridViewColumn()
                {
                    CellTemplate = new DataGridViewTextBoxCell() { },
                    HeaderText = day.ToString(),
                    Width = 80,
                    Resizable = DataGridViewTriState.False
                });

            for (int i = 1; i <= 16; ++i)
                Table.Rows.Add(new DataGridViewRow()
                {
                    Resizable = DataGridViewTriState.False,
                    HeaderCell = new DataGridViewRowHeaderCell()
                    {
                        Value = i.ToString(),
                    },
                });

            //Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode;
            Table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Table.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            Table.AutoSize = true;
        }

        public Timetable_Control()
        {
            InitializeComponent();
            Init_Table(Table);
            //AutoSize = true;
            Width = Table.Width + 4;
            Height = Table.Height + 4;
            //Dock = DockStyle.Fill;
        }

        public void Add_Subject_Selection(Subject_Selection selection)
        {
            foreach(Lecture_Time time in selection.Times)
                for (int i = time.Start_Period; i <= time.End_Period; ++i)
                    Table[(int)time.Day, i].Value = selection.Subject.Codename;
        }

        public void Remove_Subject_Selection(Subject_Selection selection)
        {
            foreach (Lecture_Time time in selection.Times)
                for (int i = time.Start_Period; i <= time.End_Period; ++i)
                    if (Table[(int)time.Day, i].Value.ToString()
                        == selection.Subject.Codename)
                        Table[(int)time.Day, i].Value = "";
        }

        public void Reset_Subject_Selections()
        {
            for (int i = 0; i < Table.Columns.Count; ++i)
                for (int j = 0; j < Table.Rows.Count; ++j)
                    if (!string.IsNullOrEmpty(Table[i, j].Value.ToString()))
                        Table[i, j].Value = "";
        }

        public void Set_Denied_Lecture_Times()
        {
            for (int i = 0; i < Table.Columns.Count; ++i)
                for (int j = 0; j < Table.Rows.Count; ++j)
                    if (Table[i, j].Selected)
                        Table[i, j].Style.BackColor = Color.Red;
        }

        public void Set_Preferred_Lecture_Times()
        {
            for (int i = 0; i < Table.Columns.Count; ++i)
                for (int j = 0; j < Table.Rows.Count; ++j)
                    if (Table[i, j].Selected)
                        Table[i, j].Style.BackColor = Color.Green;
        }

        public void Reset_Lecture_Times()
        {
            for (int i = 0; i < Table.Columns.Count; ++i)
                for (int j = 0; j < Table.Rows.Count; ++j)
                    if (Table[i, j].Style.BackColor != DefaultBackColor)
                        Table[i, j].Style.BackColor = Color.White;
        }

        public List<Lecture_Time> Get_Lecture_Times()
        {
            List<Lecture_Time> Times = new List<Lecture_Time>();
            
            for(int i = 0; i < Table.Columns.Count; ++i)
            {
                //List<Lecture_Time> Times_By_Day = new List<Lecture_Time>();
                int j = 0, k;
                while(j < Table.Rows.Count)
                {
                    if (Table[i, j].Selected)
                    {
                        for (k = j; k < Table.Rows.Count; ++k)
                            if (!Table[i, k].Selected) break;
                        Times.Add(new Lecture_Time((DayOfWeek)i, j + 1, k));
                        j = k + 1;
                    }
                    else
                        ++j;
                }
            }
                
            return Times;
        }
    }
}