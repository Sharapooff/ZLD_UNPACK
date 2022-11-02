private void button1_Click(object sender, EventArgs e)
        {
            //для ZLB архивов
            System.IO.DirectoryInfo unrar = new System.IO.DirectoryInfo("D://");// +@"\\ASK\\");
            foreach (System.IO.FileInfo f in unrar.GetFiles("*.zlb"))
            {

                var process = new System.Diagnostics.Process();
                process.StartInfo.FileName = "D://ZLD_ASK_UNPACK.exe";
                process.StartInfo.Arguments = "D://" + f.Name + " " + "D://";// + @"\\unpack\\";//сначала путь к файлу с именем файла потом директория для распаковки
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                process.BeginOutputReadLine();
                string stdError = process.StandardError.ReadToEnd();
                process.WaitForExit();
                //_zlb_arhive = true;
            }
            //окончание zlb архивов
        }