#if PORTABLE

using System;

namespace ColorCode.Common
{
  /// <summary>
  /// Portable stub
  /// </summary>
  class ReaderWriterLockSlim : IDisposable
  {

#region IDisposable Members

    public void Dispose()
    {
    }

#endregion

    public void EnterReadLock()
    {
    }

    public void ExitReadLock()
    {
    }

    public void EnterWriteLock()
    {
    }

    public void ExitWriteLock()
    {
    }

    public void EnterUpgradeableReadLock()
    {
    }

    public void ExitUpgradeableReadLock()
    {
    }
  }
}
#endif