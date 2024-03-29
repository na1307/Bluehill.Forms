﻿namespace Bluehill;

public static class ErrDialogForms {
    public static void ErrMsg(string message, bool exit) {
        ErrMsg(message);

        if (exit) {
            Application.Exit();
        }
    }

    public static DialogResult ErrMsg(string message) => ErrMsg(message, MessageBoxButtons.OK);
    public static DialogResult ErrMsg(string message, MessageBoxButtons button) => MessageBox.Show(message, "Error", button, MessageBoxIcon.Error);
}
