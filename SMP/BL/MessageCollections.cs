using SMP.Properties;

namespace SMP.BL
{
    public static class MessageCollections
    {
        public static void ShowServerError()
        {
            MessageBox.Show(Resources.ServerErrorText, Resources.ServerErrorCaption, 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowFiledsReqError() {
            MessageBox.Show(Resources.FiledReqText, Resources.FiledReqCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowEmptyDataError()
        {
            MessageBox.Show(Resources.EmptyDataText, Resources.EmptyDataCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowNoSelectedItemsError()
        {
            MessageBox.Show(Resources.NoSelectedItemsText, Resources.NoSelectedItemsCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowNotFoundError()
        {
            MessageBox.Show(Resources.NotFoundText, Resources.NotFoundCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowDeleteNotificationSell()
        {
            MessageBox.Show(Resources.DeleteNotificationText, Resources.DeleteNotificationCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Dialog
        public static bool ShowDeleteDialog()
        {
            var result = MessageBox.Show(Resources.DeleteDialogText, Resources.DeleteDialogCaption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return true;
            return false;
        }
        public static bool ShowPurSellErrorDialog()
        {
            var result = MessageBox.Show(Resources.PurSellErrorText, Resources.PurSellErrorCaption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                return true;
            return false;
        }


        // Notifications
        public static void ShowAddNotification()
        {
            var notificationSuccess = new PL.Notification.NotificationForm("تمت عملية الاضافه بنجاح!", Color.LimeGreen);
            notificationSuccess.Show();
        }
        public static void ShowEditNotification()
        {
            var notificationSuccess = new PL.Notification.NotificationForm("تمت عملية التعديل بنجاح!", Color.FromArgb(255, 128, 0));
            notificationSuccess.Show();
        }
        public static void ShowDeleteNotification()
        {
            var notificationSuccess = new PL.Notification.NotificationForm("تمت عملية الحذف بنجاح!", Color.OrangeRed);
            notificationSuccess.Show();
        }
    }
}
