using NotepadBackEnd.MyFunction;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotepadBackEnd
{
    public class EditManipulation
    {
        private bool txtContent_TextChangeRequired = true;
        private UndoRedoClass ContentData;

        public EditManipulation()
        {
            ContentData = new UndoRedoClass();
        }

        public bool TxtContent_TextChangeRequired { get => txtContent_TextChangeRequired; set => txtContent_TextChangeRequired = value; }

        public string DateTime_Now()
        {
            return DateTime.Now.ToString();
        }

        public string UndoClicked()
        {
            TxtContent_TextChangeRequired = false;
            return ContentData.Undo();
        }

        public string RedoClicked()
        {
            TxtContent_TextChangeRequired = false;
            return ContentData.Redo();
        }

        public void Add_UndoRedo(string item)
        {
            ContentData.AddItem(item);
        }

        public bool CanUndo()
        {
            return ContentData.CanUndo();
        }

        public bool CanRedo()
        {
            return ContentData.CanRedo();
        }

        public FindNextResult FindNext(FindNextSearch search)
        {
            FindNextResult result = new FindNextResult();
            int position = -1;
            StringComparison s = search.MatchCase ? StringComparison.CurrentCulture :
                StringComparison.CurrentCultureIgnoreCase;
            if (search.Direction == "UP")
            {
                position = search.Content.Substring(0, search.Position)
                    .LastIndexOf(search.SearchString, s);
                search.Success = position >= 0 ? true : false;
                result.SearchStatus = search.Success;
            }
            else
            {
                int start = search.Success ? search.Position + search.SearchString.Length :
                    search.Position;
                position = start + search.Content
                    .Substring(start, search.Content.Length - start)
                    .IndexOf(search.SearchString, s);
                search.Success = position - start >= 0 ? true : false;
                result.SearchStatus = search.Success;
            }
            result.SelectionStart = result.SearchStatus ? position : -1;
            return result;
        }



    }
}
