using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Lanymy.ChinaCalendar.DbModels;
using Lanymy.Common.ConstKeys;
using Lanymy.Common.Helpers;

namespace Lanymy.ChinaCalendar
{

    internal class GlobalSettings
    {


        /// <summary>
        /// 根目录全路径
        /// </summary>
        internal static readonly string RootDirectoryFullPath;


        /// <summary>
        /// 数据库文件全名称
        /// </summary>
        internal const string DB_FILE_FULL_NAME = "Lanymy.ChinaCalendar.db";

        internal const string ResourceDbFileKeyFullName = "Lanymy.ChinaCalendar.Resources.db";



        /// <summary>
        /// 数据库文件全路径
        /// </summary>
        internal static readonly string DbFileFullPath;


        static GlobalSettings()
        {


            RootDirectoryFullPath = PathHelper.GetCallDomainPath();

            DbFileFullPath = Path.Combine(RootDirectoryFullPath, DB_FILE_FULL_NAME);

            CheckDB();

        }


        public static void CheckDB()
        {

            if (File.Exists(DbFileFullPath)) return;

            var assembly = typeof(LanymyChinaCalendar).Assembly;
            using var sourceDbStream = assembly.GetManifestResourceStream(ResourceDbFileKeyFullName);
            DecompressStreamToSourceFile(sourceDbStream, DbFileFullPath);

        }



        public static ChinaCalendarDbContext GetChinaCalendarDbContext()
        {

            var chinaCalendarDbContext = new ChinaCalendarDbContext(string.Format("Data Source={0};", DbFileFullPath));

            if (!File.Exists(DbFileFullPath))
            {
                chinaCalendarDbContext.Database.EnsureCreated();
            }

            return chinaCalendarDbContext;

        }



        public static void DecompressStreamToSourceFile(Stream stream, string toSourceFileFullPath)
        {

            using var decompressedFileStream = File.Create(toSourceFileFullPath, BufferSizeKeys.BUFFER_SIZE_4K);
            using var decompressionStream = new GZipStream(stream, CompressionMode.Decompress);
            decompressionStream.CopyTo(decompressedFileStream);

        }





    }
}
