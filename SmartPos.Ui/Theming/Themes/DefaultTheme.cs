﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPos.Ui.Theming.Themes
{
    [ThemeName("Default")]
    public class DefaultTheme : ITheme
    {
        public Color WindowBackColor { get; }
        public Color WindowForeColor { get; }
        public Color WindowBorderColor { get; }
        public Color ControlBackColor { get; }
        public Color ControlForeColor { get; }
        public Color ButtonBackColor { get; }
        public Color ButtonForeColor { get; }
        public int ButtonBorderSize { get; }
        public Color ButtonBorderColor { get; }
        public Color ButtonDownBackColor { get; }
        public Color ButtonOverBackColor { get; }
        public Color ConfirmButtonColor { get; }
        public Color ConfirmButtonDownBackColor { get; }
        public Color ConfirmButtonOverBackColor { get; }
        public Color CancelButtonColor { get; }
        public Color CancelButtonDownBackColor { get; }
        public Color CancelButtonOverBackColor { get; }
        public Color ToolBarBackground { get; }
        public Color InfoBackColor { get; }
        public Color WarningBackColor { get; }
        public Color ErrorBackColor { get; }

        public DefaultTheme()
        {
            WindowBackColor = MaterialColors.Black;
            WindowForeColor = MaterialColors.White;
            WindowBorderColor = MaterialColors.White;

            ControlBackColor = MaterialColors.Black;
            ControlForeColor = MaterialColors.White;

            ButtonBackColor = MaterialColors.Grey(ColorDepth.C900);
            ButtonForeColor = MaterialColors.White;
            ButtonBorderSize = 1;
            ButtonBorderColor = MaterialColors.Grey(ColorDepth.C400);
            ButtonDownBackColor = MaterialColors.Grey();
            ButtonOverBackColor = MaterialColors.Grey(ColorDepth.C600);

            ConfirmButtonColor = MaterialColors.Green(ColorDepth.C600);
            ConfirmButtonDownBackColor = MaterialColors.Green(ColorDepth.C300);
            ConfirmButtonOverBackColor = MaterialColors.Green(ColorDepth.C400);

            CancelButtonColor = MaterialColors.Red();
            CancelButtonDownBackColor = MaterialColors.Red(ColorDepth.A700);
            CancelButtonOverBackColor = MaterialColors.Red(ColorDepth.C400);

            ToolBarBackground = MaterialColors.Grey(ColorDepth.C800);

            InfoBackColor = MaterialColors.Green();
            WarningBackColor = MaterialColors.Amber();
            ErrorBackColor = MaterialColors.Red();
        }
    }
}
