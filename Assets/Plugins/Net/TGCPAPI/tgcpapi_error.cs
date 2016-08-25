﻿using UnityEngine;
using System.Collections;

public enum TGCP_ERROR{
	TGCP_ERR_NONE                       = 0,
	TGCP_ERR_INVLD_HANDLE               = -1,   //句柄无效
	TGCP_ERR_INVLD_ARGUMENT             = -2,   //参数无效
	TGCP_ERR_ALLOC_FAIL                 = -3,   //分配内存失败
	TGCP_ERR_HANDLE_NOT_INITED          = -4,   //句柄未进行有效初始化
	TGCP_ERR_STR_LEN_TOO_BIG            = -5,   //字符总数超过给定的最大界限
	TGCP_ERR_CONNECT_FAILED             = -6,   //无法连接到对端进程
	TGCP_ERR_AUTH_FAIL                  = -7,   //用户身份认证失败
	TGCP_ERR_SYN_NOT_FINISHED           = -8,   //通信握手、认证进行中
	TGCP_ERR_NETWORK_EXCEPTION          = -9,   //网络出现异常
	TGCP_ERR_PEER_CLOSED_CONNECTION     = -10,  //TCP连接被对端关闭
	TGCP_ERR_PEER_STOPPED_SESSION       = -11,  //
	TGCP_ERR_PKG_NOT_COMPLETE           = -12,  //
	TGCP_ERR_UNEXPECTED_MAGIC           = -13,  //
	TGCP_ERR_UNEXPECTED_COMMAND         = -14,  //
	TGCP_ERR_PKG_ILLEGAL                = -15,  //
	TGCP_ERR_SEND_BIGGER_BUSS_DATA      = -16,  //
	TGCP_ERR_PACK_FAILED                = -17,  //
	TGCP_ERR_UNPACK_FAILED              = -18,  //
	TGCP_ERR_ASSERT_FAILED              = -19,  //
	TGCP_ERR_UNKNOW_AUTH_TYPE           = -20,  //
	TGCP_ERR_SHORT_BUF_FOR_WRITE        = -21,  //
	TGCP_ERR_GET_ACCOUNT_FAIL           = -22,  //
	TGCP_ERR_SEND_FAILTURE              = -23,  //
	TGCP_ERR_SEND_BUFFER_FULL           = -24,  //
	TGCP_ERR_SEND_UNCOMPLETED           = -25,  //
	TGCP_ERR_NO_TOKEN                   = -26,  //
	TGCP_ERR_NO_QUEUE_INFO              = -27,  //
	TGCP_ERR_STAY_IN_QUEUE              = -28,  //
	TGCP_ERR_UNSUPPORTED_ENC_METHOD     = -29,  //
	TGCP_ERR_UNSUPPORTED_KEY_MODE       = -30,  //
	TGCP_ERR_INVLD_SECRET_KEY           = -31,
	TGCP_ERR_AES_ENCRYPT                = -32,
	TGCP_ERR_AES_DECRYPT                = -33,
	TGCP_ERR_NO_OPENID                  = -34,
	TGCP_ERR_NO_APPID                   = -35,
	TGCP_ERR_UNSUPPORTED_ACCOUNT_TYPE   = -36,
	TGCP_ERR_AUTH_REFRESH_FAIL          = -37,
	TGCP_ERR_SERVER_IS_FULL             = -38,
	TGCP_ERR_GEN_DH_KEY_FAILED          = -39,
	TGCP_ERR_CUM_DH_KEY_FAILED          = -40,
	TGCP_ERR_DH_KEY_LEN_TOO_BIG         = -41,
	TGCP_ERR_GEN_RSA_KEY_FAILED         = -42,
	TGCP_ERR_ENC_DH_FAILED              = -43,
	TGCP_ERR_FLUSH_UNCOMPLETED          = -44,
	TGCP_ERR_NO_TCP_CONNECTION          = -45,
	TGCP_ERR_NOT_INIT_DH_INFO           = -46,
	TGCP_ERR_TOKEN_INVALID				= -47,//无效或过期的Token，需要让用户重新登录。
	TGCP_ERR_TOKEN_SVR_ERROR			= -48,//鉴权服务器错误（可以重试，不需要让用户重新登录）
	TGCP_ERR_COMPR_ERROR                = -49,
	TGCP_ERR_DECOMPR_ERROR              = -50,
	TGCP_ERR_UNSUPPORTED_METHOD_IN_CURRENT_MODE = -51, // 当前模式（由初始化时选择的不同接口决定）不支持该函数。
	TGCP_ERR_TIMEOUT					= -52,
    TGCP_ERR_EVENT_DATA_OUT             = -53,//tgcp不能发包
    TGCP_EVENT_WAITING                  = -54,//TGCP_EVENT_WAITING
    TGCP_EVENT_SVR_IS_FULL              = -55,//TGCP_EVENT_SVR_IS_FULL
    TGCP_EVENT_TGCP_IS_NULL             = -156,//TGCP_EVENT_SVR_IS_NULL
    TGCP_EVENT_TGCP_LONG_TIME_NOT_RECEIVE_PKG = -157,//长时间末收到包
    TGCP_EVENT_SOCKET_DISCONNECT = -158,//
    TGCP_EVENT_SOCKET_ON_OPENID_IS_NULL_OR_EMPTY = -159,//openid为空

};