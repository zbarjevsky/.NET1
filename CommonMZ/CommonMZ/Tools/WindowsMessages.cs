﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace MZ.Tools
{
	/// <summary
	/// Summary description for WM_Messages
	/// </summary
	public enum WM_Message
	{
		WM_NULL = 0x0000, //
		WM_CREATE = 0x0001, //
		WM_DESTROY = 0x0002, //
		WM_MOVE = 0x0003, //
		WM_SIZE = 0x0005, //
		WM_ACTIVATE = 0x0006, //
		WM_SETFOCUS = 0x0007, //
		WM_KILLFOCUS = 0x0008, //
		WM_ENABLE = 0x000A, //1
		WM_SETREDRAW = 0x000B, //1
		WM_SETTEXT = 0x000C, //1
		WM_GETTEXT = 0x000D, //1
		WM_GETTEXTLENGTH = 0x000E, //1
		WM_PAINT = 0x000F, //1
		WM_CLOSE = 0x0010, //1
		WM_QUERYENDSESSION = 0x0011, //1
		WM_QUERYOPEN = 0x0013, //1
		WM_ENDSESSION = 0x0016, //2
		WM_QUIT = 0x0012, //1
		WM_ERASEBKGND = 0x0014, //2
		WM_SYSCOLORCHANGE = 0x0015, //2
		WM_SHOWWINDOW = 0x0018, //2
		WM_WININICHANGE = 0x001A, //2
		WM_DEVMODECHANGE = 0x001B, //2
		WM_ACTIVATEAPP = 0x001C, //2
		WM_FONTCHANGE = 0x001D, //2
		WM_TIMECHANGE = 0x001E, //3
		WM_CANCELMODE = 0x001F, //3
		WM_SETCURSOR = 0x0020, //3
		WM_MOUSEACTIVATE = 0x0021, //3
		WM_CHILDACTIVATE = 0x0022, //3
		WM_QUEUESYNC = 0x0023, //3
		WM_GETMINMAXINFO = 0x0024, //3
		WM_PAINTICON = 0x0026, //3
		WM_ICONERASEBKGND = 0x0027, //3
		WM_NEXTDLGCTL = 0x0028, //4
		WM_SPOOLERSTATUS = 0x002A, //4
		WM_DRAWITEM = 0x002B, //4
		WM_MEASUREITEM = 0x002C, //4
		WM_DELETEITEM = 0x002D, //4
		WM_VKEYTOITEM = 0x002E, //4
		WM_CHARTOITEM = 0x002F, //4
		WM_SETFONT = 0x0030, //4
		WM_GETFONT = 0x0031, //4
		WM_SETHOTKEY = 0x0032, //5
		WM_GETHOTKEY = 0x0033, //5
		WM_QUERYDRAGICON = 0x0037, //5
		WM_COMPAREITEM = 0x0039, //5
		WM_GETOBJECT = 0x003D, //6
		WM_COMPACTING = 0x0041, //6
		WM_COMMNOTIFY = 0x0044, //68 /* no longer suported */
		WM_WINDOWPOSCHANGING = 0x0046, //7
		WM_WINDOWPOSCHANGED = 0x0047, //7
		WM_POWER = 0x0048, //7
		WM_COPYDATA = 0x004A, //7
		WM_CANCELJOURNAL = 0x004B, //7
		WM_NOTIFY = 0x004E, //7
		WM_INPUTLANGCHANGEREQUEST = 0x0050, //8
		WM_INPUTLANGCHANGE = 0x0051, //8
		WM_TCARD = 0x0052, //8
		WM_HELP = 0x0053, //8
		WM_USERCHANGED = 0x0054, //8
		WM_NOTIFYFORMAT = 0x0055, //8
		WM_CONTEXTMENU = 0x007B, //12
		WM_STYLECHANGING = 0x007C, //12
		WM_STYLECHANGED = 0x007D, //12
		WM_DISPLAYCHANGE = 0x007E, //12
		WM_GETICON = 0x007F, //12
		WM_SETICON = 0x0080, //12
		WM_NCCREATE = 0x0081, //12
		WM_NCDESTROY = 0x0082, //13
		WM_NCCALCSIZE = 0x0083, //13
		WM_NCHITTEST = 0x0084, //13
		WM_NCPAINT = 0x0085, //13
		WM_NCACTIVATE = 0x0086, //13
		WM_GETDLGCODE = 0x0087, //13
		WM_SYNCPAINT = 0x0088, //13
		WM_NCMOUSEMOVE = 0x00A0, //16
		WM_NCLBUTTONDOWN = 0x00A1, //16
		WM_NCLBUTTONUP = 0x00A2, //16
		WM_NCLBUTTONDBLCLK = 0x00A3, //16
		WM_NCRBUTTONDOWN = 0x00A4, //16
		WM_NCRBUTTONUP = 0x00A5, //16
		WM_NCRBUTTONDBLCLK = 0x00A6, //16
		WM_NCMBUTTONDOWN = 0x00A7, //16
		WM_NCMBUTTONUP = 0x00A8, //16
		WM_NCMBUTTONDBLCLK = 0x00A9, //16
		WM_NCXBUTTONDOWN = 0x00AB, //17
		WM_NCXBUTTONUP = 0x00AC, //17
		WM_NCXBUTTONDBLCLK = 0x00AD, //17
		WM_INPUT = 0x00FF, //25
		WM_KEYFIRST = 0x0100, //25
		WM_KEYDOWN = 0x0100, //25
		WM_KEYUP = 0x0101, //25
		WM_CHAR = 0x0102, //25
		WM_DEADCHAR = 0x0103, //25
		WM_SYSKEYDOWN = 0x0104, //26
		WM_SYSKEYUP = 0x0105, //26
		WM_SYSCHAR = 0x0106, //26
		WM_SYSDEADCHAR = 0x0107, //26
		WM_UNICHAR = 0x0109, //26
		WM_KEYLAST = 0x0109, //26
		WM_KEYLASTBefore0x0501 = 0x0108, //264
		WM_IME_STARTCOMPOSITION = 0x010D, //269
		WM_IME_ENDCOMPOSITION = 0x010E, //270
		WM_IME_COMPOSITION = 0x010F, //271
		WM_IME_KEYLAST = 0x010F, //271
		WM_INITDIALOG = 0x0110, //272
		WM_COMMAND = 0x0111, //273
		WM_SYSCOMMAND = 0x0112, //274
		WM_TIMER = 0x0113, //275
		WM_HSCROLL = 0x0114, //276
		WM_VSCROLL = 0x0115, //277
		WM_INITMENU = 0x0116, //278
		WM_INITMENUPOPUP = 0x0117, //279
		WM_MENUSELECT = 0x011F, //287
		WM_MENUCHAR = 0x0120, //288
		WM_ENTERIDLE = 0x0121, //289
		WM_MENURBUTTONUP = 0x0122, //290
		WM_MENUDRAG = 0x0123, //291
		WM_MENUGETOBJECT = 0x0124, //292
		WM_UNINITMENUPOPUP = 0x0125, //293
		WM_MENUCOMMAND = 0x0126, //294
		WM_CHANGEUISTATE = 0x0127, //295
		WM_UPDATEUISTATE = 0x0128, //296
		WM_QUERYUISTATE = 0x0129, //297
		WM_CTLCOLORMSGBOX = 0x0132, //306
		WM_CTLCOLOREDIT = 0x0133, //307
		WM_CTLCOLORLISTBOX = 0x0134, //308
		WM_CTLCOLORBTN = 0x0135, //309
		WM_CTLCOLORDLG = 0x0136, //310
		WM_CTLCOLORSCROLLBAR = 0x0137, //311
		WM_CTLCOLORSTATIC = 0x0138, //312
		WM_MOUSEFIRST = 0x0200, //512
		WM_MOUSEMOVE = 0x0200, //512
		WM_LBUTTONDOWN = 0x0201, //513
		WM_LBUTTONUP = 0x0202, //514
		WM_LBUTTONDBLCLK = 0x0203, //515
		WM_RBUTTONDOWN = 0x0204, //516
		WM_RBUTTONUP = 0x0205, //517
		WM_RBUTTONDBLCLK = 0x0206, //518
		WM_MBUTTONDOWN = 0x0207, //519
		WM_MBUTTONUP = 0x0208, //520
		WM_MBUTTONDBLCLK = 0x0209, //521
		WM_MOUSEWHEEL = 0x020A, //522
		WM_XBUTTONDOWN = 0x020B, //523
		WM_XBUTTONUP = 0x020C, //524
		WM_XBUTTONDBLCLK = 0x020D, //525
		WM_MOUSELAST = 0x020D, //525
		WM_MOUSELASTBefore0x0500 = 0x020A, //522
		WM_MOUSELASTBefore0x0400 = 0x0209, //521
		WM_PARENTNOTIFY = 0x0210, //528
		WM_ENTERMENULOOP = 0x0211, //529
		WM_EXITMENULOOP = 0x0212, //530
		WM_NEXTMENU = 0x0213, //531
		WM_SIZING = 0x0214, //532
		WM_CAPTURECHANGED = 0x0215, //533
		WM_MOVING = 0x0216, //534
		WM_POWERBROADCAST = 0x0218, //536
		WM_DEVICECHANGE = 0x0219, //537
		WM_MDICREATE = 0x0220, //544
		WM_MDIDESTROY = 0x0221, //545
		WM_MDIACTIVATE = 0x0222, //546
		WM_MDIRESTORE = 0x0223, //547
		WM_MDINEXT = 0x0224, //548
		WM_MDIMAXIMIZE = 0x0225, //549
		WM_MDITILE = 0x0226, //550
		WM_MDICASCADE = 0x0227, //551
		WM_MDIICONARRANGE = 0x0228, //552
		WM_MDIGETACTIVE = 0x0229, //553
		WM_MDISETMENU = 0x0230, //560
		WM_ENTERSIZEMOVE = 0x0231, //561
		WM_EXITSIZEMOVE = 0x0232, //562
		WM_DROPFILES = 0x0233, //563
		WM_MDIREFRESHMENU = 0x0234, //564
		WM_IME_SETCONTEXT = 0x0281, //641
		WM_IME_NOTIFY = 0x0282, //642
		WM_IME_CONTROL = 0x0283, //643
		WM_IME_COMPOSITIONFULL = 0x0284, //644
		WM_IME_SELECT = 0x0285, //645
		WM_IME_CHAR = 0x0286, //646
		WM_IME_REQUEST = 0x0288, //648
		WM_IME_KEYDOWN = 0x0290, //656
		WM_IME_KEYUP = 0x0291, //657
		WM_MOUSEHOVER = 0x02A1, //673
		WM_MOUSELEAVE = 0x02A3, //675
		WM_NCMOUSEHOVER = 0x02A0, //672
		WM_NCMOUSELEAVE = 0x02A2, //674
		WM_WTSSESSION_CHANGE = 0x02B1, //689
		WM_TABLET_FIRST = 0x02c0, //704
		WM_TABLET_LAST = 0x02df, //735
		WM_CUT = 0x0300, //768
		WM_COPY = 0x0301, //769
		WM_PASTE = 0x0302, //770
		WM_CLEAR = 0x0303, //771
		WM_UNDO = 0x0304, //772
		WM_RENDERFORMAT = 0x0305, //773
		WM_RENDERALLFORMATS = 0x0306, //774
		WM_DESTROYCLIPBOARD = 0x0307, //775
		WM_DRAWCLIPBOARD = 0x0308, //776
		WM_PAINTCLIPBOARD = 0x0309, //777
		WM_VSCROLLCLIPBOARD = 0x030A, //778
		WM_SIZECLIPBOARD = 0x030B, //779
		WM_ASKCBFORMATNAME = 0x030C, //780
		WM_CHANGECBCHAIN = 0x030D, //781
		WM_HSCROLLCLIPBOARD = 0x030E, //782
		WM_QUERYNEWPALETTE = 0x030F, //783
		WM_PALETTEISCHANGING = 0x0310, //784
		WM_PALETTECHANGED = 0x0311, //785
		WM_HOTKEY = 0x0312, //786
		WM_PRINT = 0x0317, //791
		WM_PRINTCLIENT = 0x0318, //792
		WM_APPCOMMAND = 0x0319, //793
		WM_THEMECHANGED = 0x031A, //794
		WM_HANDHELDFIRST = 0x0358, //856
		WM_HANDHELDLAST = 0x035F, //863
		WM_AFXFIRST = 0x0360, //864
		WM_AFXLAST = 0x037F, //895
		WM_PENWINFIRST = 0x0380, //896
		WM_PENWINLAST = 0x038F, //911
		WM_APP = 0x8000, //32768
		WM_USER = 0x0400, //1024
		WM_HELP_Before0x0400 = 0x000c, //12
	}

	public class WindowsMessages
	{
		public static List<WM_Message> MessagesList;

		static WindowsMessages()
		{
			MessagesList = Enum.GetValues(typeof(WM_Message)).OfType<WM_Message>().ToList();
		}

		public static string MessageNameFromInt(int msg)
		{
			//WM_Message res = MessagesList.FirstOrDefault(m => (int)m == msg);
			foreach (WM_Message m in MessagesList)
			{
				if (msg == (int)m)
					return m.ToString();
			}
			return "!!UNKNOWN!!";
		}
	}
}
