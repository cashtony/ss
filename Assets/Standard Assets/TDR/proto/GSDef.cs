/* This file is generated by tdr. */
/* No manual modification is permitted. */

/* metalib version: 101 */
/* metalib md5sum: f8305675cf6b3330d5923f3f17b6f7be */

/* creation time: Thu Aug 18 18:14:29 2016 */
/* tdr version: 2.7.12, build at 20151212 */


using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using tsf4g_tdr_csharp;

namespace GSProtocal
{


public class MACROS_GSDEF
{
 public const int PROTOCOL_VERSION = 1; // 协议版本号，每次做了协议修改，递增 +1=10
 public const int GS_ROLE_NAME_LEN = 32;
 public const int MAX_OPENID_LEN = 128;
 public const int MAX_PF_LENGTH = 128; // MSDK pf长度
 public const int MAX_GAME_TOKEN_LENGTH = 64; // game token 长度
 public const int MAX_PAY_TOKEN_LENGTH = 256; // MSDK paytoken长度
 public const int GS_MAX_MONEY_TYPE = 4; // 货币类型数量
 public const int GS_MAX_RESOURCE_TYPE = 20; // 资源点数类型数量
 public const int GS_MAX_ITEM_BAG_SIZE = 1000; // 道具包裹最大容量
 public const int GS_MAX_SELL_ITEM_NUM = 10; // 同时出售道具ID数量
 public const int GS_MAX_CHAT_MSG_LEN = 128; // 聊天内容最大长度
 public const int GS_MAX_CHAT_QUEUE_LEN = 40; // 聊天信息队列最大长度
 public const int GS_MAX_GOT_THINGS_ITEM_NUM = 10; // 奖励获得道具最大数量
 public const int GS_MAX_GOT_THINGS_INSTANCE_NUM = 10; // 奖励获得实例物品最大数量
 public const int GS_MAX_GOT_THINGS = 10;

 /* macros in macrogroup UPDATE_TYPE */
 public const int UPDATE_TYPE_ALL = 1; // 全量
 public const int UPDATE_TYPE_REPLACE = 2; // 增量
 public const int UPDATE_TYPE_DEL = 3; // 删除

 /* macros in macrogroup REWARD_SOURCE */
 public const int GM_ADD = 1001; // GM指令
}


public enum  UPDATE_TYPE
{
 UPDATE_TYPE_ALL = 1, // 全量
 UPDATE_TYPE_REPLACE = 2, // 增量
 UPDATE_TYPE_DEL = 3, // 删除
}
public enum  REWARD_SOURCE
{
 GM_ADD = 1001, // GM指令
}


public class CSItemObj : tsf4g_csharp_interface
{
 /* public members */
 public Int32 iId; // id
 public Int32 iCount; // value

 /* construct methods */
 public CSItemObj()
 {
 }

 /* public methods */
 public TdrError.ErrorType construct()
 {
  TdrError.ErrorType ret = TdrError.ErrorType.TDR_NO_ERROR;

  /* no need to  set defaultvalue */

  return ret;
 }


#if (TSF4G_TDR_NO_PACK)
 public TdrError.ErrorType pack(ref byte[] buffer, int size, ref int usedSize , uint cutVer)
 {
#if (DEBUG)
  TdrDebug.tdrTrace();
#endif
  return TdrError.ErrorType.TDR_ERR_METHOD_NOT_IMPLEMENTED;
 }

 public TdrError.ErrorType pack(ref TdrWriteBuf destBuf,  uint cutVer)
 {
#if (DEBUG)
  TdrDebug.tdrTrace();
#endif
  return TdrError.ErrorType.TDR_ERR_METHOD_NOT_IMPLEMENTED;
 }
#else  // TSF4G_TDR_NO_PACK
 public TdrError.ErrorType pack(ref byte[] buffer, int size, ref int usedSize , uint cutVer)
 {
  if (null == buffer || 0 == buffer.GetLength(0) || (size > buffer.GetLength(0)))
  {
      return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
  }

  TdrWriteBuf destBuf = new TdrWriteBuf(ref buffer, size);
  TdrError.ErrorType ret = pack(ref destBuf, cutVer);
  if (ret == TdrError.ErrorType.TDR_NO_ERROR)
  {
   buffer = destBuf.getBeginPtr();

   usedSize = destBuf.getUsedSize();
  }

  return ret;
 }

 public TdrError.ErrorType pack(ref TdrWriteBuf destBuf,  uint cutVer)
 {
  TdrError.ErrorType ret = TdrError.ErrorType.TDR_NO_ERROR;

  /* adjust cutversion */
  if (0 == cutVer || CSItemObj.CURRVERSION < cutVer)
  {
   cutVer = CSItemObj.CURRVERSION;
  }

  /* check cutversion */
  if (CSItemObj.BASEVERSION > cutVer)
  {
#if (DEBUG)
   TdrDebug.tdrTrace();
#endif
   return TdrError.ErrorType.TDR_ERR_CUTVER_TOO_SMALL;
  }

  /* pack member: this.iId */
  {
   ret = destBuf.writeInt32(this.iId);
   if (TdrError.ErrorType.TDR_NO_ERROR != ret)
   {
#if (DEBUG)
    TdrDebug.tdrTrace();
#endif
    return ret;
   }
  }

  /* pack member: this.iCount */
  {
   ret = destBuf.writeInt32(this.iCount);
   if (TdrError.ErrorType.TDR_NO_ERROR != ret)
   {
#if (DEBUG)
    TdrDebug.tdrTrace();
#endif
    return ret;
   }
  }

  return ret;
 }
#endif  // TSF4G_TDR_NO_PACK


#if (TSF4G_TDR_NO_UNPACK)
 public TdrError.ErrorType unpack(ref byte[] buffer, int size, ref int usedSize , uint cutVer)
 {
#if (DEBUG)
  TdrDebug.tdrTrace();
#endif
  return TdrError.ErrorType.TDR_ERR_METHOD_NOT_IMPLEMENTED;
 }

 public TdrError.ErrorType unpack(ref TdrReadBuf srcBuf, uint cutVer)
 {
#if (DEBUG)
  TdrDebug.tdrTrace();
#endif
  return TdrError.ErrorType.TDR_ERR_METHOD_NOT_IMPLEMENTED;
 }
#else  // TSF4G_TDR_NO_UNPACK
 public TdrError.ErrorType unpack(ref byte[] buffer, int size, ref int usedSize , uint cutVer)
 {
  if (null == buffer || 0 == buffer.GetLength(0) || size > buffer.GetLength(0))
  {
#if (DEBUG)
   TdrDebug.tdrTrace();
#endif
   return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
  }

  TdrReadBuf srcBuf = new TdrReadBuf(ref buffer, size);
  TdrError.ErrorType ret = unpack(ref srcBuf, cutVer);

  usedSize = srcBuf.getUsedSize();

  return ret;
 }

 public TdrError.ErrorType unpack(ref TdrReadBuf srcBuf, uint cutVer)
 {
  TdrError.ErrorType ret = TdrError.ErrorType.TDR_NO_ERROR;

  /* adjust cutversion */
  if (0 == cutVer || CSItemObj.CURRVERSION < cutVer)
  {
   cutVer = CSItemObj.CURRVERSION;
  }

  /* check cutversion */
  if (CSItemObj.BASEVERSION > cutVer)
  {
#if (DEBUG)
   TdrDebug.tdrTrace();
#endif
   return TdrError.ErrorType.TDR_ERR_CUTVER_TOO_SMALL;
  }

  /* unpack member: this.iId */
  {
   ret = srcBuf.readInt32(ref this.iId);
   if (TdrError.ErrorType.TDR_NO_ERROR != ret)
   {
#if (DEBUG)
    TdrDebug.tdrTrace();
#endif
    return ret;
   }
  }

  /* unpack member: this.iCount */
  {
   ret = srcBuf.readInt32(ref this.iCount);
   if (TdrError.ErrorType.TDR_NO_ERROR != ret)
   {
#if (DEBUG)
    TdrDebug.tdrTrace();
#endif
    return ret;
   }
  }

  return ret;
 }
#endif  // TSF4G_TDR_NO_UNPACK


#if (TSF4G_TDR_NO_LOAD)
 public TdrError.ErrorType load(ref byte[] buffer, int size, ref int usedSize , uint cutVer)
 {
#if (DEBUG)
  TdrDebug.tdrTrace();
#endif
  return TdrError.ErrorType.TDR_ERR_METHOD_NOT_IMPLEMENTED;
 }

 public TdrError.ErrorType load(ref TdrReadBuf srcBuf, uint cutVer)
 {
#if (DEBUG)
  TdrDebug.tdrTrace();
#endif
  return TdrError.ErrorType.TDR_ERR_METHOD_NOT_IMPLEMENTED;
 }
#else  // TSF4G_TDR_NO_LOAD
 public TdrError.ErrorType load(ref byte[] buffer, int size, ref int usedSize , uint cutVer)
 {
  if (null == buffer || 0 == buffer.GetLength(0) || size > buffer.GetLength(0))
  {
#if (DEBUG)
   TdrDebug.tdrTrace();
#endif
   return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
  }

  TdrReadBuf srcBuf = new TdrReadBuf(ref buffer, size);
  TdrError.ErrorType ret = load(ref srcBuf, cutVer);

  usedSize = srcBuf.getUsedSize();

  return ret;
 }

 public TdrError.ErrorType load(ref TdrReadBuf srcBuf, uint cutVer)
 {
  srcBuf.disableEndian();
  TdrError.ErrorType ret = TdrError.ErrorType.TDR_NO_ERROR;

  /* adjust cutversion */
  if (0 == cutVer || CSItemObj.CURRVERSION < cutVer)
  {
   cutVer = CSItemObj.CURRVERSION;
  }

  /* check cutversion */
  if (CSItemObj.BASEVERSION > cutVer)
  {
#if (DEBUG)
   TdrDebug.tdrTrace();
#endif
   return TdrError.ErrorType.TDR_ERR_CUTVER_TOO_SMALL;
  }

  /* load member: this.iId */
  {
   ret = srcBuf.readInt32(ref this.iId);
   if (TdrError.ErrorType.TDR_NO_ERROR != ret)
   {
#if (DEBUG)
    TdrDebug.tdrTrace();
#endif
    return ret;
   }
  }

  /* load member: this.iCount */
  {
   ret = srcBuf.readInt32(ref this.iCount);
   if (TdrError.ErrorType.TDR_NO_ERROR != ret)
   {
#if (DEBUG)
    TdrDebug.tdrTrace();
#endif
    return ret;
   }
  }

  return ret;
 }
#endif  // TSF4G_TDR_NO_LOAD


#if (TSF4G_TDR_NO_VISUALIZE)
 public TdrError.ErrorType visualize(ref string buffer, int indent, char separator)
 {
#if (DEBUG)
  TdrDebug.tdrTrace();
#endif
  return TdrError.ErrorType.TDR_ERR_METHOD_NOT_IMPLEMENTED;
 }

 public TdrError.ErrorType visualize(ref TdrVisualBuf destBuf, int indent, char separator)
 {
#if (DEBUG)
  TdrDebug.tdrTrace();
#endif
  return TdrError.ErrorType.TDR_ERR_METHOD_NOT_IMPLEMENTED;
 }
#else  // TSF4G_TDR_NO_VISUALIZE
 /* set indent = -1 to disable indent , default: separator = '\n' */
 public TdrError.ErrorType visualize(ref string buffer, int indent, char separator)
 {
  TdrVisualBuf destBuf = new TdrVisualBuf();
  TdrError.ErrorType ret = visualize(ref destBuf, indent, separator);

  buffer = destBuf.getVisualBuf();

  return ret;
 }

 /* set indent = -1 to disable indent , default: separator = '\n' */
 public TdrError.ErrorType visualize(ref TdrVisualBuf destBuf, int indent, char separator)
 {
  TdrError.ErrorType ret = TdrError.ErrorType.TDR_NO_ERROR;

  /* visualize member: this.iId */
  ret = TdrBufUtil.printVariable(ref destBuf, indent, separator, "[iId]", "{0:d}", this.iId);
  if (TdrError.ErrorType.TDR_NO_ERROR != ret)
  {
#if (DEBUG)
   TdrDebug.tdrTrace();
#endif
   return ret;
  }

  /* visualize member: this.iCount */
  ret = TdrBufUtil.printVariable(ref destBuf, indent, separator, "[iCount]", "{0:d}", this.iCount);
  if (TdrError.ErrorType.TDR_NO_ERROR != ret)
  {
#if (DEBUG)
   TdrDebug.tdrTrace();
#endif
   return ret;
  }

  return ret;
 }
#endif  // TSF4G_TDR_NO_VISUALIZE


#if (TSF4G_TDR_NO_GETSIZEINFO)
 public TdrError.ErrorType getSizeInfo(byte[] buffer, int size, ref uint sizeInfo)
 {
#if (DEBUG)
  TdrDebug.tdrTrace();
#endif
  return TdrError.ErrorType.TDR_ERR_METHOD_NOT_IMPLEMENTED;
 }

 public TdrError.ErrorType getSizeInfo(TdrReadBuf srcBuf, ref uint sizeInfo)
 {
#if (DEBUG)
  TdrDebug.tdrTrace();
#endif
  return TdrError.ErrorType.TDR_ERR_METHOD_NOT_IMPLEMENTED;
 }
#else  // TSF4G_TDR_NO_GETSIZEINFO
 public TdrError.ErrorType getSizeInfo(byte[] buffer, int size, ref uint sizeInfo)
 {
  if (0 == buffer.GetLength(0) || size > buffer.GetLength(0))
  {
#if (DEBUG)
   TdrDebug.tdrTrace();
#endif
   return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
  }

  TdrReadBuf srcBuf = new TdrReadBuf(ref buffer, size);
  TdrError.ErrorType ret = getSizeInfo(srcBuf, ref sizeInfo);

  return ret;
 }

 public TdrError.ErrorType getSizeInfo(TdrReadBuf srcBuf, ref uint sizeInfo)
 {
  return TdrError.ErrorType.TDR_ERR_HAVE_NOT_SET_SIZEINFO;
 }
#endif  // TSF4G_TDR_NO_GETSIZEINFO

 /* meta version info */
 public static readonly uint BASEVERSION = 1;
 public static readonly uint CURRVERSION = 1;
 /* entry version info */

 /* length of string or wstring */
}


}
