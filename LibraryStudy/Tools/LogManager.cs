using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace LibraryStudy.Tools
{
    public enum LogType { Daily, Monthly}

    public class LogManager
    {
        private string _path;

        #region Constructors
        public LogManager(string path, LogType logType, string prefix, string postfix)
        {
            _path = path;
            _SetLogPath(logType, prefix, postfix);
        }

        //인자가 prefix, postfix 2개일 경우
        public LogManager(string prefix, string postfix) : this(Path.Combine(Application.Root, "Log"), LogType.Daily, prefix, postfix)
        {

        }
        
        public LogManager() : this(Path.Combine(Application.Root, "Log"), LogType.Daily, null, null) //인수가 없는 생성자가 호출되면, Path.Combine(Application.Root, "Log")을 인수가 있는 생성자로 넘김
        {

        }
        #endregion

        #region Methods
        private void _SetLogPath(LogType logType, string prefix, string postfix)
        {
            string path = string.Empty;// null대신 공백
            string name = string.Empty;

            switch (logType)
            {
                case LogType.Daily:
                    //경로 생성 {0}에 년도 {1}에 월
                    path = string.Format(@"{0}\{1}\", DateTime.Now.Year, DateTime.Now.ToString("MM"));
                    name = DateTime.Now.ToString("yyyyMMdd");
                    break;
                case LogType.Monthly:
                    //경로 생성 {0}에 년도 {1}에 월
                    path = string.Format(@"{0}\{1}\", DateTime.Now.Year, DateTime.Now.ToString("MM"));
                    name = DateTime.Now.ToString("yyyyMM");
                    break;
            }

            //스위치문에서 바뀐 이름으로 폴더 이름 갱신
            _path = Path.Combine(_path, path);

            //폴더가 존재하지 않으면 생성
            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }

            //pre,postfix null이나 공백이 아니면
            if (string.IsNullOrEmpty(prefix))
            {
                name = prefix + name;
            }
            if (string.IsNullOrEmpty(postfix))
            {
                name = name + postfix;
            }
            name +=".txt";

            //string logFile = DateTime.Now.ToString("yyyyMMdd") + ".txt";
            _path = Path.Combine(_path, name);
        }

        public void Write(string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.Write(data);
                }
            }
            catch(Exception e)
            {

            }

        }

        public void WriteLine(string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyyMMdd HH:mm:ss \t") + data);
                }
            }
            catch (Exception e)
            {
                
            }



        }

        #endregion

    }
}
