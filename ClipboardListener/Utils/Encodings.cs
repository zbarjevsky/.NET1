using System;
using System.Xml;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace ClipboardManager
{
    //https://stackoverflow.com/questions/1212742/xml-serialize-generic-list-of-serializable-objects
    [Serializable]
    [XmlInclude(typeof(EncodingItemData))]
    public class EncodingsList
    {
        [XmlArray("Encodings")]
        [XmlArrayItem("EncodingItemData")]
        public List<EncodingItemData> Encodings { get; set; } = new List<EncodingItemData>();

        public override string ToString()
        {
            int sel = CountSelected();
            return string.Format("Selected Encodings {0} of {1}", sel, Encodings.Count);
        }

        private int CountSelected()
        {
            int count = 0;
            foreach (EncodingItemData e in Encodings)
                if (e.ShowInMenu) count++;
            return count;
        }

        public void UpdateEncodingsAfterLoadFromXml()
        {
            List<EncodingItemData> loaded = new List<EncodingItemData>(Encodings);
            Encodings.Clear();
            foreach (EncodingInfo ei in Encoding.GetEncodings())
            {
                bool show = GetShow(ei.CodePage, loaded);
                Encodings.Add(new EncodingItemData() { Enc = ei.GetEncoding(), ShowInMenu = show });
            }//end foreach
        }

        private bool GetShow(int codePage, List<EncodingItemData> loaded)
        {
            foreach (EncodingItemData data in loaded)
            {
                if (data.CodePage == codePage)
                    return data.ShowInMenu;
            }
            return false;
        }
    }

    [Serializable]
    [XmlType("EncodingItemData")]
    [TypeConverter(typeof(PropertySorter))]
    public class EncodingItemData
    {
        [XmlAttribute(AttributeName = "Show")]
        [DisplayName("Show in Menu")]
        [PropertyOrder(1)]
        public bool ShowInMenu { get; set; } = false;

        private string _name = "N/A";
        [PropertyOrder(2)]
        [XmlAttribute(AttributeName = "Name")]
        public string EncodingName { get { return _name; } set { } }

        private int _codePage = Encoding.UTF8.CodePage;
        [ReadOnly(true)]
        [PropertyOrder(3)]
        [XmlAttribute(AttributeName = "CodePage")]
        public int CodePage { get { return _codePage; } set { SetCodePage(value); } } 

        private Encoding _e = null;
        [XmlIgnore]
        [ReadOnly(true)]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [PropertyOrder(4)]
        public Encoding Enc { get { return _e; } set { SetCodePage(value); } }

        private void SetCodePage(Encoding enc)
        {
            if (enc != null)
                SetCodePage(enc.CodePage);
            else
                SetCodePage(0);
        }

        private void SetCodePage(int codePage)
        {
            try
            {
                _codePage = codePage;
                _e = Encoding.GetEncoding(codePage);
                _name = _e.EncodingName;
            }
            catch (Exception err)
            {
                ShowInMenu = false;
                _codePage = 0;
                _e = null;
                _name = err.Message;
            }
        }

        public override string ToString()
        {
            return string.Format("({0}) {1}", ShowInMenu?"+":"-", EncodingName);
        }
    }

    public class EncodingsHelper
	{
		//public class Item : IComparable
		//{
		//	public bool bEnable = false;
		//	public string sName = "";
		//	public Encoding e = null;

		//	public Item(Encoding e)
		//	{
		//		this.e = e;
		//		this.sName = e.EncodingName;
		//	}//end constructor

		//	public int CompareTo(object obj)
		//	{
		//		Item i = (Item)obj;
		//		if ( i == null )
		//			return -1;

		//		return sName.CompareTo(i.sName);
		//	}//end CompareTo
		//}//end class Item

		//public ArrayList m_vItems = new ArrayList();
		//private static RichTextBox m_RichTextBoxSrc = null, m_RichTextBoxDst = null;
        private static Func<string> GetText = () => { return ""; };
        private static Action<string> SetText = (text) => { };

        public static int CreateEncodingsMenuItems(ToolStripItemCollection root,
            Func<string> getText, Action<string> setText, 
            List<EncodingItemData> encodingsList)
		{
            GetText = getText;
            SetText = setText;
			//m_RichTextBoxSrc = richSrc;
			//m_RichTextBoxDst = richDst;

			ArrayList vEncodingMenus = new ArrayList();
			for ( int i = 0; i < encodingsList.Count; i++ )
			{
                EncodingItemData itm = encodingsList[i];
				if ( !itm.ShowInMenu )
					continue;

				ToolStripItem x = new ToolStripMenuItem(itm.EncodingName);
				x.Tag = itm;
				x.Click += MenuItem_Encoding_Click;

				vEncodingMenus.Add(x);
			}//end for
			
			//leave first 2 items
			while ( root.Count > 2 )
				root.RemoveAt(root.Count - 1);

			if ( vEncodingMenus.Count == 0 )
				return 0;

			root.AddRange((ToolStripItem[])vEncodingMenus.ToArray(typeof(ToolStripItem)));

			return root.Count;
		}//end CreateEncodingsMenuItems

		private static void MenuItem_Encoding_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem itm = (ToolStripMenuItem)sender;
            EncodingItemData i = itm.Tag as EncodingItemData;

			System.Diagnostics.Trace.WriteLine("MenuItem_Encoding_Click: "+itm.Text);

			SetText(ConvertToEncoding(GetText(), i.Enc));
		}//end MenuItem_Encoding_Click

        //https://stackoverflow.com/questions/1922199/c-sharp-convert-string-from-utf-8-to-iso-8859-1-latin1-h
        private static string ConvertToEncoding(string s, Encoding e)
		{
            byte[] currentBytes = Encoding.GetEncoding("ISO-8859-1").GetBytes(s);

			byte [] convertedBytes = Encoding.Convert(Encoding.GetEncoding("ISO-8859-1"), e, currentBytes);

            string convertedText = Encoding.UTF8.GetString(convertedBytes);

            return convertedText;
        }//end Decode

        private static string Decode(byte[] currentBytes, Encoding e)
        {
            Decoder decoder = e.GetDecoder();
            int count = decoder.GetCharCount(currentBytes, 0, currentBytes.Length);
            char[] targetChars = new char[count];
            count = decoder.GetChars(currentBytes, 0, currentBytes.Length, targetChars, 0);
            return new string(targetChars);
        }
	}//end class Encodings
}//end namespace ClipboardListener
