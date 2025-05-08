using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Download_Manager.Service.FileLogic
{
    internal class FileLogic
    {
        public Func<ResponseFile, bool> validatorFunction { get; }
        public FileLogic(Func<ResponseFile, bool> validatorFunction) {
            this.validatorFunction = validatorFunction;
        }

        public FileLogic()
        {
            this.validatorFunction = (file => true);
        }

        public ResponseFile getValidHighestScoreFile(List<ResponseFile> fileList)
        {
            return fileList.Where(validatorFunction).MaxBy(file => file.Score);
        }
    }
}
