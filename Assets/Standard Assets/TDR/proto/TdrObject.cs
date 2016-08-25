/* This file is generated by tdr. */
/* No manual modification is permitted. */

/* creation time: Thu Aug 18 18:14:29 2016 */
/* tdr version: 2.7.12, build at 20151212 */

using System;

namespace tsf4g_tdr_csharp
{


public interface IPackable
{
 TdrError.ErrorType pack(ref byte[] buffer, int size, ref int usedSize , uint cutVer);
}

public interface IUnpackable
{
 TdrError.ErrorType unpack(ref byte[] buffer, int size, ref int usedSize , uint cutVer);
}

public interface tsf4g_csharp_interface
: IPackable, IUnpackable
{
 TdrError.ErrorType construct();
 TdrError.ErrorType pack(ref TdrWriteBuf destBuf, uint cutVer);
 TdrError.ErrorType unpack(ref TdrReadBuf srcBuf, uint cutVer);
 TdrError.ErrorType load(ref byte[] buffer, int size, ref int usedSize, uint cutVer);
 TdrError.ErrorType load(ref TdrReadBuf srcBuf, uint cutVer);
 TdrError.ErrorType getSizeInfo(byte[] buffer, int size, ref uint sizeInfo);
 TdrError.ErrorType getSizeInfo(TdrReadBuf srcBuf, ref uint sizeInfo);
 TdrError.ErrorType visualize(ref string buffer, int indent, char separator);
 TdrError.ErrorType visualize(ref TdrVisualBuf destBuf, int indent, char separator);
}


}