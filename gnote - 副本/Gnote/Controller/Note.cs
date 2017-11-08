using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using Gnote.Model;

namespace Gnote.Controller
{
    class Note
    {
        private string _noteTitle;

        public string NoteTitle
        {
            get { return _noteTitle; }
            set { _noteTitle = value; }
        }
        private DateTime _noteCreateTime;

        public DateTime NoteCreateTime
        {
            get { return _noteCreateTime; }
            set { _noteCreateTime = value; }
        }
        private DateTime _noteModifyTime;

        public DateTime NoteModifyTime
        {
            get { return _noteModifyTime; }
            set { _noteModifyTime = value; }
        }
        private int _hasDelete;

        public int HasDelete
        {
            get { return _hasDelete; }
            set { _hasDelete = value; }
        }
        private int _notebook;

        public int Notebook
        {
            get { return _notebook; }
            set { _notebook = value; }
        }
        private string _content;

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }


        //笔记列表
        public MySqlDataReader listNote()
        {
            MNote mnote = new MNote();
            MySqlDataReader reader = mnote.list_note();
            return reader;
        }
        public MySqlDataReader listNote(int notebook_no, string type)
        {
            if (type == "notebook")
            {
                MNote mnote = new MNote();
                MySqlDataReader reader = mnote.list_note_notenook(notebook_no);
                return reader;
            }
            else// if (type == "label")
            {
                MNote mnote = new MNote();
                MySqlDataReader reader = mnote.list_note_label(notebook_no);
                return reader;
            }

        }


        //新建笔记
        public void newNote(int notebook)
        {
            NoteTitle = "无标题笔记本";
            NoteCreateTime = DateTime.Now;
            NoteModifyTime = DateTime.Now;
            HasDelete = 0;
            Notebook = notebook;
            Content = "";
            new MNote().newnote(NoteTitle, NoteCreateTime, NoteModifyTime, HasDelete, Notebook, Content);
            Console.WriteLine("进入新建笔记控制器");

        }

        //显示笔记详情
        public MySqlDataReader ShowDetail(int note_no)
        {
            return new MNote().ShowDetail(note_no);
        }
        
        //保存笔记
        public void SaveNote(int note_no, string note_name, DateTime note_modify_time, string note_content)
        {
            new MNote().SaveNote(note_no, note_name, note_modify_time, note_content);
        }
    }
}
