using System;

namespace TailBlazer.Domain.FileHandling
{
    public interface IFileWatcher
    {
        IObservable<FileNotification> Latest { get; }

        string FullName { get; }
        string Name { get; }
        string Folder { get; }
    }
}