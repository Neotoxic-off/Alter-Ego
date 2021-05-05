using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDR
{
    public partial class Alter_Ego : Form
    {
        List<string> to_remove = new List<string>();
        public Alter_Ego()
        {
            InitializeComponent();
        }

        private int count_char(string str, char c)
        {
            int total = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    total++;
            }
            return (total);
        }

        private string crop(string message)
        {
            if (count_char(message, '\\') >= 3)
            {
                return ($"{message.Split('\\')[0]}\\{message.Split('\\')[1]}\\...\\{message.Split('\\')[count_char(message, '\\')]}");
            }

            return (message);
        }

        private int UILogs(string message)
        {
            logs.Invoke(new MethodInvoker(delegate
            {
                logs.Text = message;
                logs.Refresh();
            }));

            return (0);
        }

        private int display(string message)
        {
            status.Invoke(new MethodInvoker(delegate
            {
                DateTime date = DateTime.Now;
                string result = date.ToString("hh:mm:ss tt");
                status.AppendText($"{result} | {message}\n");
                status.SelectionStart = status.Text.Length;
                status.ScrollToCaret();
                status.Refresh();
            }));
            
            return (0);
        }

        private int add_to_trash(string message)
        {
            remove.Invoke(new MethodInvoker(delegate
            {
                remove.AppendText($"{message}\n");
                remove.SelectionStart = remove.Text.Length;
                remove.ScrollToCaret();
                remove.Refresh();
            }));
           
            return (0);
        }

        private int get_folder()
        {
            directory.ShowDialog();
            if (directory.SelectedPath.Length == 0)
                return (-1);

            return (0);
        }

        private int check_ext(string file)
        {
            string[] filter_image = { ".png", ".jpg", ".jpeg", ".gif" };
            string[] filter_music = { ".mp3", ".wav", ".flac", ".riff", ".bwf", ".ogg", ".aiff" };
            string[] filter_videos = { ".mp4", ".webm", ".mkv", ".flv", ".vob", ".gif", ".avi", ".m4v", ".flv" };

            if (only_images.Checked == true)
            {
                for (int i = 0; i < filter_image.Length; i++)
                {
                    if (file.EndsWith(filter_image[i]))
                        return (1);
                }

                return (0);
            }

            if (only_music.Checked == true)
            {
                for (int i = 0; i < filter_music.Length; i++)
                {
                    if (file.EndsWith(filter_music[i]))
                        return (1);
                }

                return (0);
            }

            if (only_videos.Checked == true)
            {
                for (int i = 0; i < filter_videos.Length; i++)
                {
                    if (file.EndsWith(filter_videos[i]))
                        return (1);
                }

                return (0);
            }

            return (1);
        }

        private bool are_equal(byte[] s1, byte[] s2)
        {
            return (s1.SequenceEqual(s2));
        }

        private async Task<Task> purge_all()
        {
            for (int i = 0; i < to_remove.Count; i++)
            {
                if (File.Exists(to_remove[i]) == true)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    File.Delete(to_remove[i]);
                }
            }
            to_remove = null;
            return (Task.CompletedTask);
        }

        private async Task<Task> check_all()
        {
            int value = 0;
            int duplicate = 0;
            string[] files = Directory.GetFiles(directory.SelectedPath, "*.*", SearchOption.AllDirectories);
            int size = files.Length;
            MD5 md5 = MD5.Create();
            byte[] original = null;
            byte[] compared = null;

            display($"Starting scan: {size} files");

            for (int i = 0; i < size; i++)
            {
                groupBox2.Invoke(new MethodInvoker(delegate
                {
                    groupBox2.Text = $" Duplicate: {duplicate} ";
                }));

                if (check_ext(files[i]) == 1)
                {
                    for (int j = i + 1; j < size && to_remove.Contains(files[j]) == false; j++)
                    {
                        if (check_ext(files[j]) == 1)
                        {
                            original = md5.ComputeHash(File.OpenRead(files[i]));
                            compared = md5.ComputeHash(File.OpenRead(files[j]));

                            if (original.Length == compared.Length)
                            {
                                if (are_equal(original, compared) == true)
                                {
                                    to_remove.Add(files[j]);
                                    add_to_trash($"{crop(files[j])}");
                                    duplicate++;
                                }
                                else
                                {
                                    UILogs($"{crop(files[j])}");
                                }
                            }
                        }
                    }
                }

                progress.Invoke(new MethodInvoker(delegate
                {
                    value = ((i * 100) / files.Length);
                    progress.Value = value;
                    percent.Text = $"{value} %";
                }));
            }
            progress.Invoke(new MethodInvoker(delegate
            {
                value = 0;
                progress.Value = value;
                percent.Text = $"Scan complete";
            }));

            display($"Scan complete: {duplicate} duplicate");
            return (Task.CompletedTask);
        }

        private async void browse_Click(object sender, EventArgs e)
        {
            Task check_task = null;
            Task clean_task = null;

            if (get_folder() == 0)
            {
                remove.Clear();
                status.Clear();
                logs.Clear();

                display($"Directory set {crop(directory.SelectedPath)}");
                check_task = await Task.Run(() => check_all());
                check_task.Wait();
                if (auto_remove.Checked == true)
                {
                    clean_task = await Task.Run(() => purge_all());
                    clean_task.Wait();
                }

                return;
            }
            display($"Directory not set");
        }

        private async Task<Task> change_theme()
        {
            if (dark_theme.Checked == true)
            {
                BackColor = Color.FromArgb(35, 39, 42);
                groupBox1.ForeColor = Color.White;
                groupBox2.ForeColor = Color.White;
                groupBox3.ForeColor = Color.White;
                groupBox4.ForeColor = Color.White;
                groupBox5.ForeColor = Color.White;
                groupBox6.ForeColor = Color.White;

                logs.BackColor = Color.FromArgb(44, 47, 51);
                logs.ForeColor = Color.White;

                remove.BackColor = Color.FromArgb(44, 47, 51);
                remove.ForeColor = Color.White;

                status.BackColor = Color.FromArgb(44, 47, 51);
                status.ForeColor = Color.White;

                browse.ForeColor = Color.White;
                cancel.ForeColor = Color.White;

                percent.ForeColor = Color.White;
            } else {
                BackColor = SystemColors.Control;
                groupBox1.ForeColor = SystemColors.ControlText;
                groupBox2.ForeColor = SystemColors.ControlText;
                groupBox3.ForeColor = SystemColors.ControlText;
                groupBox4.ForeColor = SystemColors.ControlText;
                groupBox5.ForeColor = SystemColors.ControlText;
                groupBox6.ForeColor = SystemColors.ControlText;

                logs.BackColor = SystemColors.Control;
                logs.ForeColor = SystemColors.WindowText;

                remove.BackColor = SystemColors.Control;
                remove.ForeColor = SystemColors.WindowText;

                status.BackColor = SystemColors.Control;
                status.ForeColor = SystemColors.WindowText;

                browse.ForeColor = SystemColors.ControlText;
                cancel.ForeColor = SystemColors.ControlText;

                percent.ForeColor = SystemColors.ControlText;

            }

            return (Task.CompletedTask);
        }

        private void only_images_CheckedChanged(object sender, EventArgs e)
        {
            if (only_images.Checked == true)
            {
                only_music.Checked = false;
                only_videos.Checked = false;
                display($"Only images set");
            }
            else
                display($"Only images unset");
        }

        private void dark_theme_CheckedChanged(object sender, EventArgs e)
        {
            if (dark_theme.Checked == true)
                display("Dark theme set");
            else
                display("Dark theme unset");
            change_theme().Wait();
        }

        private void auto_remove_CheckedChanged(object sender, EventArgs e)
        {
            if (auto_remove.Checked == true)
                display($"Auto remove set");
            else
                display($"Auto remove unset");
        }

        private void only_music_CheckedChanged(object sender, EventArgs e)
        {
            if (only_music.Checked == true)
            {
                only_images.Checked = false;
                only_videos.Checked = false;
                display("Only music set");
            }
            else
                display("Only music unset");
        }

        private void only_videos_CheckedChanged(object sender, EventArgs e)
        {
            if (only_videos.Checked == true)
            {
                only_images.Checked = false;
                only_music.Checked = false;
                display("Only videos set");
            }
            else
                display("Only videos unset");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
