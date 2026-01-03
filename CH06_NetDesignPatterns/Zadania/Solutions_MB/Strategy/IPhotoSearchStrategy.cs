using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringToDesignPatterns.CH06_NetDesignPatterns.Zadania.Solutions_MB.Strategy
{
    public interface IPhotoSearchStrategy
    {
        Task<List<PhotoResult>> SearchPhotos(string category);
    }
}
