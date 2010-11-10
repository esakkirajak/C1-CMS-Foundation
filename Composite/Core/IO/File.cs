﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Core.IO
{
    /// <summary>
    /// This should be a part of the I/O layer
    /// </summary>
    /// <exclude />
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)] 
    public static class File11
    {
        // THIS IS NOT A PART OF System.IO.File
        public static long GetLength(string path)
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);

            return fileInfo.Length; 
        }


        //[SecuritySafeCritical]
        //public static void AppendAllLines(string path, IEnumerable<string> contents){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static void AppendAllText(string path, string contents)
        {
            System.IO.File.AppendAllText(path, contents);
        }
        
        //[SecuritySafeCritical]
        //public static void AppendAllText(string path, string contents, Encoding encoding){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static StreamWriter AppendText(string path){ throw new NotImplementedException(); }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static void Copy(string sourceFileName, string destFileName)
        {
            System.IO.File.Copy(sourceFileName, destFileName); 
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            System.IO.File.Copy(sourceFileName, destFileName, overwrite);
        }
        
        //[SecuritySafeCritical, TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static C1FileStream Create(string path)
        {
            return new C1FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None);
        }
        
        //[SecuritySafeCritical, TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        //public static FileStream Create(string path, int bufferSize){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static FileStream Create(string path, int bufferSize, System.IO.FileOptions options){ throw new NotImplementedException(); }
        //public static FileStream Create(string path, int bufferSize, System.IO.FileOptions options, System.Security.AccessControl.FileSecurity fileSecurity){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static StreamWriter CreateText(string path){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static void Decrypt(string path){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static void Delete(string path)
        {
            System.IO.File.Delete(path);
        }
        
        //[SecuritySafeCritical]
        //public static void Encrypt(string path){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static bool Exists(string path)
        {
            return System.IO.File.Exists(path);
        }
        
        //[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
        //public static System.Security.AccessControl.FileSecurity GetAccessControl(string path){ throw new NotImplementedException(); }
        //public static System.Security.AccessControl.FileSecurity GetAccessControl(string path, System.Security.AccessControl.AccessControlSections includeSections){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static System.IO.FileAttributes GetAttributes(string path)
        {
            return System.IO.File.GetAttributes(path); 
        }
        
        //[SecuritySafeCritical]



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static DateTime GetCreationTime(string path)
        {
            return System.IO.File.GetCreationTime(path); 
        }
        
        //[SecuritySafeCritical]
        //public static DateTime GetCreationTimeUtc(string path){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static DateTime GetLastAccessTime(string path){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static DateTime GetLastAccessTimeUtc(string path){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static DateTime GetLastWriteTime(string path)
        {
            return System.IO.File.GetLastWriteTime(path);
        }
        
        //[SecuritySafeCritical]
        //public static DateTime GetLastWriteTimeUtc(string path){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static void Move(string sourceFileName, string destFileName)
        {
            System.IO.File.Move(sourceFileName, destFileName); 
        }
        
        //[SecuritySafeCritical]



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static C1FileStream Open(string path, System.IO.FileMode mode)
        {
            return new C1FileStream(path, mode); 
        }
        
        //[SecuritySafeCritical, TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static C1FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access)
        { 
            return new C1FileStream(path, mode, access);
        }
        
        //[SecuritySafeCritical]


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static C1FileStream Open(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share)
        { 
            return new C1FileStream(path, mode, access, share); 
        }
        
        //[SecuritySafeCritical]


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static C1FileStream OpenRead(string path)
        {
            return new C1FileStream(path, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
        }
        
        //[SecuritySafeCritical]
        //public static StreamReader OpenText(string path){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static FileStream OpenWrite(string path){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static byte[] ReadAllBytes(string path)
        {
            return System.IO.File.ReadAllBytes(path);
        }
        
        //[SecuritySafeCritical]



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static string[] ReadAllLines(string path)
        {
            return System.IO.File.ReadAllLines(path); 
        }
        
        //[SecuritySafeCritical]
        //public static string[] ReadAllLines(string path, Encoding encoding){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static string ReadAllText(string path)
        {
            return System.IO.File.ReadAllText(path); 
        }
        
        //[SecuritySafeCritical]
        //public static string ReadAllText(string path, Encoding encoding){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static IEnumerable<string> ReadLines(string path){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static IEnumerable<string> ReadLines(string path, Encoding encoding){ throw new NotImplementedException(); }
        //public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static void SetAccessControl(string path, System.Security.AccessControl.FileSecurity fileSecurity){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static void SetAttributes(string path, System.IO.FileAttributes fileAttributes)
        {
            System.IO.File.SetAttributes(path, fileAttributes); 
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static void SetCreationTime(string path, DateTime creationTime)
        {
            System.IO.File.SetCreationTime(path, creationTime); 
        }
        //[SecuritySafeCritical]
        //public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc){ throw new NotImplementedException(); }
        //public static void SetLastAccessTime(string path, DateTime lastAccessTime){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc){ throw new NotImplementedException(); }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            System.IO.File.SetLastWriteTime(path, lastWriteTime);
        }


        //[SecuritySafeCritical]
        //public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static void WriteAllBytes(string path, byte[] bytes){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static void WriteAllLines(string path, IEnumerable<string> contents)
        { 
            System.IO.File.WriteAllLines(path, contents); 
        }
        
        //[SecuritySafeCritical]
        //public static void WriteAllLines(string path, string[] contents){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]
        //public static void WriteAllLines(string path, string[] contents, Encoding encoding){ throw new NotImplementedException(); }
        //[SecuritySafeCritical]


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static void WriteAllText(string path, string contents)
        {
            System.IO.File.WriteAllText(path, contents); 
        }
        
        //[SecuritySafeCritical]


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileClass:DoNotUseFileClass", Justification = "The implementation may use it")]
        public static void WriteAllText(string path, string contents, Encoding encoding)
        {
            System.IO.File.WriteAllText(path, contents, encoding); 
        }
    }
}
