using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace Dashboard.WFA
{
    public class ComponenteDX
    {
        private Control _controle;

        public ComponenteDX(Control controle)
        {
            _controle = controle;
        }

        public void Configurar()
        {
            if (_controle is DateEdit)
                ConfigurarDateEdit();
            else if (_controle is LookUpEdit)
                ConfigurarLookupEdit();
            else if (_controle is PopupContainerEdit)
                ConfigurarPopupContainerEdit();
            else if (_controle is CalcEdit)
                ConfigurarCalcEdit();
            else if (_controle is ImageComboBoxEdit)
                ConfigurarImageComboBoxEdit();
            else if (_controle is ColorPickEdit)
                ConfigurarColorPickEdit();
            else if (_controle is ComboBoxEdit)
                ConfigurarComboBoxEdit();
            else if (_controle is TextEdit)
                ConfigurarTextEdit();
            else if (_controle is GridControl)
                ConfigurarGridControl();
            else if (_controle is CheckedListBoxControl)
                ConfigurarCheckedListBoxControl();
            else if (_controle is CheckedComboBoxEdit)
                ConfigurarCheckedComboBoxEdit();
        }

        private void ConfigurarGridControl()
        {
            foreach (GridView view in (_controle as GridControl).Views)
            {
                /*view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
                view.OptionsBehavior.AllowIncrementalSearch = true;
                view.OptionsBehavior.Editable = false;
                view.OptionsCustomization.AllowColumnMoving = false;
                view.OptionsCustomization.AllowColumnResizing = false;
                view.OptionsCustomization.AllowFilter = false;
                view.OptionsCustomization.AllowGroup = false;
                view.OptionsMenu.EnableColumnMenu = false;
                view.OptionsSelection.EnableAppearanceFocusedCell = false;
                view.OptionsView.ColumnAutoWidth = false;
                view.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
                view.OptionsView.ShowGroupPanel = false;*/
                view.OptionsView.ShowIndicator = false;
                view.ColumnPanelRowHeight = 28;
                view.RowHeight = 28;
                view.ViewCaptionHeight = 24;
            }
        }

        private void ConfigurarTextEdit()
        {            
        }

        private void ConfigurarColorPickEdit()
        {
            (_controle as ColorPickEdit).Properties.ColorAlignment = DevExpress.Utils.HorzAlignment.Center;
            (_controle as ColorPickEdit).Properties.StoreColorAsInteger = true;
            (_controle as ColorPickEdit).Properties.AutomaticColorButtonCaption = "Automático";
        }

        private void ConfigurarDateEdit()
        {
            (_controle as DateEdit).Properties.ShowToday = false;
            (_controle as DateEdit).Properties.Mask.UseMaskAsDisplayFormat = true;
            (_controle as DateEdit).Properties.Mask.MaskType = string.IsNullOrWhiteSpace((_controle as DateEdit).Properties.Mask.EditMask) || (_controle as DateEdit).Properties.Mask.EditMask == "g" || (_controle as DateEdit).Properties.Mask.EditMask == "G" ? DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret : DevExpress.XtraEditors.Mask.MaskType.Simple;
            (_controle as DateEdit).Properties.Mask.EditMask = string.IsNullOrWhiteSpace((_controle as DateEdit).Properties.Mask.EditMask) || (_controle as DateEdit).Properties.Mask.EditMask == "d" ? "99/99/9999" : (_controle as DateEdit).Properties.Mask.EditMask;
        }

        private void ConfigurarLookupEdit()
        {
            (_controle as LookUpEdit).Properties.NullText = "";
            (_controle as LookUpEdit).Properties.ShowFooter = false;
            (_controle as LookUpEdit).Properties.ShowHeader = false;
            (_controle as LookUpEdit).Properties.ShowLines = false;
            (_controle as LookUpEdit).Properties.PopupWidth = (_controle as LookUpEdit).Width;
            (_controle as LookUpEdit).Properties.PopupFormMinSize = new System.Drawing.Size((_controle as LookUpEdit).Width, (_controle as LookUpEdit).Height);
        }

        private void ConfigurarPopupContainerEdit()
        {
            (_controle as PopupContainerEdit).Properties.NullText = "";
            (_controle as PopupContainerEdit).Properties.ShowPopupCloseButton = false;
            (_controle as PopupContainerEdit).Properties.PopupSizeable = false;
        }

        private void ConfigurarCalcEdit()
        {
            (_controle as CalcEdit).Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            (_controle as CalcEdit).Properties.Buttons.Clear();
            (_controle as CalcEdit).Properties.Mask.UseMaskAsDisplayFormat = true;
            (_controle as CalcEdit).Properties.Mask.EditMask = string.IsNullOrWhiteSpace((_controle as CalcEdit).Properties.Mask.EditMask) ? "n2" : (_controle as CalcEdit).Properties.Mask.EditMask;
            (_controle as CalcEdit).Properties.Mask.MaskType = string.IsNullOrWhiteSpace((_controle as CalcEdit).Properties.Mask.EditMask) ? DevExpress.XtraEditors.Mask.MaskType.Numeric : (_controle as CalcEdit).Properties.Mask.MaskType;
            (_controle as CalcEdit).Properties.MaxLength = (_controle as CalcEdit).Properties.MaxLength == 0 ? 13 : (_controle as CalcEdit).Properties.MaxLength;
        }

        private void ConfigurarImageComboBoxEdit()
        {
        }

        private void ConfigurarComboBoxEdit()
        {
            (_controle as ComboBoxEdit).Properties.NullText = "";
            (_controle as ComboBoxEdit).Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
        }

        private void ConfigurarCheckedListBoxControl()
        {
        }

        private void ConfigurarCheckedComboBoxEdit()
        {
            (_controle as CheckedComboBoxEdit).Properties.PopupSizeable = false;
            (_controle as CheckedComboBoxEdit).Properties.SelectAllItemCaption = "(Selecionar Todos)";
        }
    }
}
