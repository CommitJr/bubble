﻿#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


struct InvokerActionInvoker0
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj)
	{
		method->invoker_method(methodPtr, method, obj, NULL, NULL);
	}
};
template <typename T1>
struct InvokerActionInvoker1;
template <typename T1>
struct InvokerActionInvoker1<T1*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1)
	{
		void* params[1] = { p1 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};
template <typename T1, typename T2>
struct InvokerActionInvoker2;
template <typename T1, typename T2>
struct InvokerActionInvoker2<T1*, T2*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2)
	{
		void* params[2] = { p1, p2 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};
template <typename T1, typename T2, typename T3, typename T4>
struct InvokerActionInvoker4
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1 p1, T2 p2, T3 p3, T4 p4)
	{
		void* params[4] = { &p1, &p2, &p3, &p4 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct InvokerActionInvoker5;
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct InvokerActionInvoker5<T1*, T2, T3, T4, T5>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2 p2, T3 p3, T4 p4, T5 p5)
	{
		void* params[5] = { p1, &p2, &p3, &p4, &p5 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};

// System.Action`1<System.Boolean>
struct Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C;
// System.Action`3<System.Boolean,System.Boolean,System.Int32>
struct Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB;
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.Action
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.RemoteConfigSettings
struct RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52;
// System.String
struct String_t;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// UnityEngine.Analytics.AnalyticsSessionInfo/IdentityTokenChanged
struct IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395;
// UnityEngine.Analytics.AnalyticsSessionInfo/SessionStateChanged
struct SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C;
// UnityEngine.RemoteSettings/UpdatedEventHandler
struct UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4;

IL2CPP_EXTERN_C RuntimeClass* Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* AnalyticsSessionInfo_tDE8F7A9E13EF9723E2D975F76E916753DA61AD76_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250_il2cpp_TypeInfo_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;

struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_t6B4A7D64487421A1C7A9ACB5578F8A35510E2A0C 
{
};

// UnityEngine.Analytics.AnalyticsSessionInfo
struct AnalyticsSessionInfo_tDE8F7A9E13EF9723E2D975F76E916753DA61AD76  : public RuntimeObject
{
};

struct AnalyticsSessionInfo_tDE8F7A9E13EF9723E2D975F76E916753DA61AD76_StaticFields
{
	// UnityEngine.Analytics.AnalyticsSessionInfo/SessionStateChanged UnityEngine.Analytics.AnalyticsSessionInfo::sessionStateChanged
	SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* ___sessionStateChanged_0;
	// UnityEngine.Analytics.AnalyticsSessionInfo/IdentityTokenChanged UnityEngine.Analytics.AnalyticsSessionInfo::identityTokenChanged
	IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* ___identityTokenChanged_1;
};
struct Il2CppArrayBounds;

// UnityEngine.Analytics.ContinuousEvent
struct ContinuousEvent_t71122F6F65BF7EA8490EA664A55D5C03790CB6CF  : public RuntimeObject
{
};

// UnityEngine.RemoteConfigSettingsHelper
struct RemoteConfigSettingsHelper_t29B2673892F8181388B45FFEEE354B3773629588  : public RuntimeObject
{
};

// UnityEngine.RemoteSettings
struct RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250  : public RuntimeObject
{
};

struct RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250_StaticFields
{
	// UnityEngine.RemoteSettings/UpdatedEventHandler UnityEngine.RemoteSettings::Updated
	UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* ___Updated_0;
	// System.Action UnityEngine.RemoteSettings::BeforeFetchFromServer
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___BeforeFetchFromServer_1;
	// System.Action`3<System.Boolean,System.Boolean,System.Int32> UnityEngine.RemoteSettings::Completed
	Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB* ___Completed_2;
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2  : public ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F
{
};

struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_StaticFields
{
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___enumSeperatorCharArray_0;
};
// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_com
{
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.Int64
struct Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3 
{
	// System.Int64 System.Int64::m_value
	int64_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// UnityEngine.Analytics.AnalyticsSessionState
struct AnalyticsSessionState_t45365B3C4890CEFCFDBD5438073BE8626CFA120E 
{
	// System.Int32 UnityEngine.Analytics.AnalyticsSessionState::value__
	int32_t ___value___2;
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// UnityEngine.RemoteConfigSettings
struct RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52  : public RuntimeObject
{
	// System.IntPtr UnityEngine.RemoteConfigSettings::m_Ptr
	intptr_t ___m_Ptr_0;
	// System.Action`1<System.Boolean> UnityEngine.RemoteConfigSettings::Updated
	Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* ___Updated_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.RemoteConfigSettings
struct RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
	Il2CppMethodPointer ___Updated_1;
};
// Native definition for COM marshalling of UnityEngine.RemoteConfigSettings
struct RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshaled_com
{
	intptr_t ___m_Ptr_0;
	Il2CppMethodPointer ___Updated_1;
};

// UnityEngine.RemoteConfigSettingsHelper/Tag
struct Tag_t65C719EEBD4BD6BC3814607DC26A76E97D24E034 
{
	// System.Int32 UnityEngine.RemoteConfigSettingsHelper/Tag::value__
	int32_t ___value___2;
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// System.Action`1<System.Boolean>
struct Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C  : public MulticastDelegate_t
{
};

// System.Action`3<System.Boolean,System.Boolean,System.Int32>
struct Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB  : public MulticastDelegate_t
{
};

// System.Action
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07  : public MulticastDelegate_t
{
};

// UnityEngine.Analytics.AnalyticsSessionInfo/IdentityTokenChanged
struct IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395  : public MulticastDelegate_t
{
};

// UnityEngine.Analytics.AnalyticsSessionInfo/SessionStateChanged
struct SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C  : public MulticastDelegate_t
{
};

// UnityEngine.RemoteSettings/UpdatedEventHandler
struct UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4  : public MulticastDelegate_t
{
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771  : public RuntimeArray
{
	ALIGN_FIELD (8) Delegate_t* m_Items[1];

	inline Delegate_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// System.Void System.Action`3<System.Boolean,System.Boolean,System.Int32>::Invoke(T1,T2,T3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_3_Invoke_mB1AE88F5C5FE161C85EA4A58D5CC535721E01B21_gshared_inline (Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB* __this, bool ___arg10, bool ___arg21, int32_t ___arg32, const RuntimeMethod* method) ;
// System.Void System.Action`1<System.Boolean>::Invoke(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_m69C8773D6967F3B224777183E24EA621CE056F8F_gshared_inline (Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* __this, bool ___obj0, const RuntimeMethod* method) ;

// System.Void UnityEngine.RemoteSettings/UpdatedEventHandler::Invoke()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50_inline (UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* __this, const RuntimeMethod* method) ;
// System.Void System.Action::Invoke()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_Invoke_m7126A54DACA72B845424072887B5F3A51FC3808E_inline (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* __this, const RuntimeMethod* method) ;
// System.Void System.Action`3<System.Boolean,System.Boolean,System.Int32>::Invoke(T1,T2,T3)
inline void Action_3_Invoke_mB1AE88F5C5FE161C85EA4A58D5CC535721E01B21_inline (Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB* __this, bool ___arg10, bool ___arg21, int32_t ___arg32, const RuntimeMethod* method)
{
	((  void (*) (Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB*, bool, bool, int32_t, const RuntimeMethod*))Action_3_Invoke_mB1AE88F5C5FE161C85EA4A58D5CC535721E01B21_gshared_inline)(__this, ___arg10, ___arg21, ___arg32, method);
}
// System.Void System.Action`1<System.Boolean>::Invoke(T)
inline void Action_1_Invoke_m69C8773D6967F3B224777183E24EA621CE056F8F_inline (Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* __this, bool ___obj0, const RuntimeMethod* method)
{
	((  void (*) (Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C*, bool, const RuntimeMethod*))Action_1_Invoke_m69C8773D6967F3B224777183E24EA621CE056F8F_gshared_inline)(__this, ___obj0, method);
}
// System.Void UnityEngine.Analytics.AnalyticsSessionInfo/SessionStateChanged::Invoke(UnityEngine.Analytics.AnalyticsSessionState,System.Int64,System.Int64,System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5_inline (SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* __this, int32_t ___sessionState0, int64_t ___sessionId1, int64_t ___sessionElapsedTime2, bool ___sessionChanged3, const RuntimeMethod* method) ;
// System.Void UnityEngine.Analytics.AnalyticsSessionInfo/IdentityTokenChanged::Invoke(System.String)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_inline (IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* __this, String_t* ___token0, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.RemoteSettings::RemoteSettingsUpdated(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RemoteSettings_RemoteSettingsUpdated_mC219C2BAA771BF07A1388264A931E49419142F56 (bool ___wasLastUpdatedFromServer0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* V_0 = NULL;
	bool V_1 = false;
	{
		UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* L_0 = ((RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250_StaticFields*)il2cpp_codegen_static_fields_for(RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250_il2cpp_TypeInfo_var))->___Updated_0;
		V_0 = L_0;
		UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* L_1 = V_0;
		V_1 = (bool)((!(((RuntimeObject*)(UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4*)L_1) <= ((RuntimeObject*)(RuntimeObject*)NULL)))? 1 : 0);
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_0016;
		}
	}
	{
		UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* L_3 = V_0;
		NullCheck(L_3);
		UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50_inline(L_3, NULL);
	}

IL_0016:
	{
		return;
	}
}
// System.Void UnityEngine.RemoteSettings::RemoteSettingsBeforeFetchFromServer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RemoteSettings_RemoteSettingsBeforeFetchFromServer_m84AAE01E2E6C81CDD55965748FF10883348483B3 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* V_0 = NULL;
	bool V_1 = false;
	{
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_0 = ((RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250_StaticFields*)il2cpp_codegen_static_fields_for(RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250_il2cpp_TypeInfo_var))->___BeforeFetchFromServer_1;
		V_0 = L_0;
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_1 = V_0;
		V_1 = (bool)((!(((RuntimeObject*)(Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07*)L_1) <= ((RuntimeObject*)(RuntimeObject*)NULL)))? 1 : 0);
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_0016;
		}
	}
	{
		Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* L_3 = V_0;
		NullCheck(L_3);
		Action_Invoke_m7126A54DACA72B845424072887B5F3A51FC3808E_inline(L_3, NULL);
	}

IL_0016:
	{
		return;
	}
}
// System.Void UnityEngine.RemoteSettings::RemoteSettingsUpdateCompleted(System.Boolean,System.Boolean,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RemoteSettings_RemoteSettingsUpdateCompleted_mB6A303826465F0DC733C16F1EA60F7AF0693D7FB (bool ___wasLastUpdatedFromServer0, bool ___settingsChanged1, int32_t ___response2, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB* V_0 = NULL;
	bool V_1 = false;
	{
		Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB* L_0 = ((RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250_StaticFields*)il2cpp_codegen_static_fields_for(RemoteSettings_t9DFFC747AB3E7A39DF4527F245B529A407427250_il2cpp_TypeInfo_var))->___Completed_2;
		V_0 = L_0;
		Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB* L_1 = V_0;
		V_1 = (bool)((!(((RuntimeObject*)(Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB*)L_1) <= ((RuntimeObject*)(RuntimeObject*)NULL)))? 1 : 0);
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_0019;
		}
	}
	{
		Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB* L_3 = V_0;
		bool L_4 = ___wasLastUpdatedFromServer0;
		bool L_5 = ___settingsChanged1;
		int32_t L_6 = ___response2;
		NullCheck(L_3);
		Action_3_Invoke_mB1AE88F5C5FE161C85EA4A58D5CC535721E01B21_inline(L_3, L_4, L_5, L_6, NULL);
	}

IL_0019:
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50_Multicast(UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* __this, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* currentDelegate = reinterpret_cast<UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50_Open(UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* __this, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(method);
}
void UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50_OpenStaticInvoker(UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker0::Invoke(__this->___method_ptr_0, method, NULL);
}
void UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50_ClosedStaticInvoker(UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker1< RuntimeObject* >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4 (UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void UnityEngine.RemoteSettings/UpdatedEventHandler::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpdatedEventHandler__ctor_mB914409481F8FDC738B4EDB1DBB4883F743F863A (UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___method1);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___method1))
	{
		bool isOpen = parameterCount == 0;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___method1))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50_Open;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
		__this->___method_code_6 = (intptr_t)__this->___m_target_2;
	}
	__this->___extra_arg_5 = (intptr_t)&UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50_Multicast;
}
// System.Void UnityEngine.RemoteSettings/UpdatedEventHandler::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50 (UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* __this, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.RemoteConfigSettings
IL2CPP_EXTERN_C void RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshal_pinvoke(const RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52& unmarshaled, RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshaled_pinvoke& marshaled)
{
	marshaled.___m_Ptr_0 = unmarshaled.___m_Ptr_0;
	marshaled.___Updated_1 = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(unmarshaled.___Updated_1));
}
IL2CPP_EXTERN_C void RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshal_pinvoke_back(const RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshaled_pinvoke& marshaled, RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52& unmarshaled)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	intptr_t unmarshaledm_Ptr_temp_0;
	memset((&unmarshaledm_Ptr_temp_0), 0, sizeof(unmarshaledm_Ptr_temp_0));
	unmarshaledm_Ptr_temp_0 = marshaled.___m_Ptr_0;
	unmarshaled.___m_Ptr_0 = unmarshaledm_Ptr_temp_0;
	unmarshaled.___Updated_1 = il2cpp_codegen_marshal_function_ptr_to_delegate<Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C>(marshaled.___Updated_1, Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C_il2cpp_TypeInfo_var);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___Updated_1), (void*)il2cpp_codegen_marshal_function_ptr_to_delegate<Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C>(marshaled.___Updated_1, Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C_il2cpp_TypeInfo_var));
}
// Conversion method for clean up from marshalling of: UnityEngine.RemoteConfigSettings
IL2CPP_EXTERN_C void RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshal_pinvoke_cleanup(RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.RemoteConfigSettings
IL2CPP_EXTERN_C void RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshal_com(const RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52& unmarshaled, RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshaled_com& marshaled)
{
	marshaled.___m_Ptr_0 = unmarshaled.___m_Ptr_0;
	marshaled.___Updated_1 = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(unmarshaled.___Updated_1));
}
IL2CPP_EXTERN_C void RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshal_com_back(const RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshaled_com& marshaled, RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52& unmarshaled)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	intptr_t unmarshaledm_Ptr_temp_0;
	memset((&unmarshaledm_Ptr_temp_0), 0, sizeof(unmarshaledm_Ptr_temp_0));
	unmarshaledm_Ptr_temp_0 = marshaled.___m_Ptr_0;
	unmarshaled.___m_Ptr_0 = unmarshaledm_Ptr_temp_0;
	unmarshaled.___Updated_1 = il2cpp_codegen_marshal_function_ptr_to_delegate<Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C>(marshaled.___Updated_1, Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C_il2cpp_TypeInfo_var);
	Il2CppCodeGenWriteBarrier((void**)(&unmarshaled.___Updated_1), (void*)il2cpp_codegen_marshal_function_ptr_to_delegate<Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C>(marshaled.___Updated_1, Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C_il2cpp_TypeInfo_var));
}
// Conversion method for clean up from marshalling of: UnityEngine.RemoteConfigSettings
IL2CPP_EXTERN_C void RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshal_com_cleanup(RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.RemoteConfigSettings::RemoteConfigSettingsUpdated(UnityEngine.RemoteConfigSettings,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RemoteConfigSettings_RemoteConfigSettingsUpdated_m530866ACE0F9A9150A55646274FC1D8C404D63E8 (RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52* ___rcs0, bool ___wasLastUpdatedFromServer1, const RuntimeMethod* method) 
{
	Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* V_0 = NULL;
	bool V_1 = false;
	{
		RemoteConfigSettings_tC979947EE51355162B3241B9F80D95A8FD25FE52* L_0 = ___rcs0;
		NullCheck(L_0);
		Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* L_1 = L_0->___Updated_1;
		V_0 = L_1;
		Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* L_2 = V_0;
		V_1 = (bool)((!(((RuntimeObject*)(Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C*)L_2) <= ((RuntimeObject*)(RuntimeObject*)NULL)))? 1 : 0);
		bool L_3 = V_1;
		if (!L_3)
		{
			goto IL_0018;
		}
	}
	{
		Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* L_4 = V_0;
		bool L_5 = ___wasLastUpdatedFromServer1;
		NullCheck(L_4);
		Action_1_Invoke_m69C8773D6967F3B224777183E24EA621CE056F8F_inline(L_4, L_5, NULL);
	}

IL_0018:
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Analytics.AnalyticsSessionInfo::CallSessionStateChanged(UnityEngine.Analytics.AnalyticsSessionState,System.Int64,System.Int64,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnalyticsSessionInfo_CallSessionStateChanged_m7192B6C5DE1BCA7143D3814C0001F32940EFADA4 (int32_t ___sessionState0, int64_t ___sessionId1, int64_t ___sessionElapsedTime2, bool ___sessionChanged3, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnalyticsSessionInfo_tDE8F7A9E13EF9723E2D975F76E916753DA61AD76_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* V_0 = NULL;
	bool V_1 = false;
	{
		SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* L_0 = ((AnalyticsSessionInfo_tDE8F7A9E13EF9723E2D975F76E916753DA61AD76_StaticFields*)il2cpp_codegen_static_fields_for(AnalyticsSessionInfo_tDE8F7A9E13EF9723E2D975F76E916753DA61AD76_il2cpp_TypeInfo_var))->___sessionStateChanged_0;
		V_0 = L_0;
		SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* L_1 = V_0;
		V_1 = (bool)((!(((RuntimeObject*)(SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C*)L_1) <= ((RuntimeObject*)(RuntimeObject*)NULL)))? 1 : 0);
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_001a;
		}
	}
	{
		SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* L_3 = V_0;
		int32_t L_4 = ___sessionState0;
		int64_t L_5 = ___sessionId1;
		int64_t L_6 = ___sessionElapsedTime2;
		bool L_7 = ___sessionChanged3;
		NullCheck(L_3);
		SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5_inline(L_3, L_4, L_5, L_6, L_7, NULL);
	}

IL_001a:
	{
		return;
	}
}
// System.Void UnityEngine.Analytics.AnalyticsSessionInfo::CallIdentityTokenChanged(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AnalyticsSessionInfo_CallIdentityTokenChanged_mE4B62112455D41343CD9FBB9D45FF62FEFB6D5DA (String_t* ___token0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AnalyticsSessionInfo_tDE8F7A9E13EF9723E2D975F76E916753DA61AD76_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* V_0 = NULL;
	bool V_1 = false;
	{
		IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* L_0 = ((AnalyticsSessionInfo_tDE8F7A9E13EF9723E2D975F76E916753DA61AD76_StaticFields*)il2cpp_codegen_static_fields_for(AnalyticsSessionInfo_tDE8F7A9E13EF9723E2D975F76E916753DA61AD76_il2cpp_TypeInfo_var))->___identityTokenChanged_1;
		V_0 = L_0;
		IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* L_1 = V_0;
		V_1 = (bool)((!(((RuntimeObject*)(IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395*)L_1) <= ((RuntimeObject*)(RuntimeObject*)NULL)))? 1 : 0);
		bool L_2 = V_1;
		if (!L_2)
		{
			goto IL_0017;
		}
	}
	{
		IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* L_3 = V_0;
		String_t* L_4 = ___token0;
		NullCheck(L_3);
		IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_inline(L_3, L_4, NULL);
	}

IL_0017:
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5_Multicast(SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* __this, int32_t ___sessionState0, int64_t ___sessionId1, int64_t ___sessionElapsedTime2, bool ___sessionChanged3, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* currentDelegate = reinterpret_cast<SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, int32_t, int64_t, int64_t, bool, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, ___sessionState0, ___sessionId1, ___sessionElapsedTime2, ___sessionChanged3, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5_Open(SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* __this, int32_t ___sessionState0, int64_t ___sessionId1, int64_t ___sessionElapsedTime2, bool ___sessionChanged3, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (int32_t, int64_t, int64_t, bool, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___sessionState0, ___sessionId1, ___sessionElapsedTime2, ___sessionChanged3, method);
}
void SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5_OpenStaticInvoker(SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* __this, int32_t ___sessionState0, int64_t ___sessionId1, int64_t ___sessionElapsedTime2, bool ___sessionChanged3, const RuntimeMethod* method)
{
	InvokerActionInvoker4< int32_t, int64_t, int64_t, bool >::Invoke(__this->___method_ptr_0, method, NULL, ___sessionState0, ___sessionId1, ___sessionElapsedTime2, ___sessionChanged3);
}
void SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5_ClosedStaticInvoker(SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* __this, int32_t ___sessionState0, int64_t ___sessionId1, int64_t ___sessionElapsedTime2, bool ___sessionChanged3, const RuntimeMethod* method)
{
	InvokerActionInvoker5< RuntimeObject*, int32_t, int64_t, int64_t, bool >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2, ___sessionState0, ___sessionId1, ___sessionElapsedTime2, ___sessionChanged3);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C (SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* __this, int32_t ___sessionState0, int64_t ___sessionId1, int64_t ___sessionElapsedTime2, bool ___sessionChanged3, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(int32_t, int64_t, int64_t, int32_t);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Native function invocation
	il2cppPInvokeFunc(___sessionState0, ___sessionId1, ___sessionElapsedTime2, static_cast<int32_t>(___sessionChanged3));

}
// System.Void UnityEngine.Analytics.AnalyticsSessionInfo/SessionStateChanged::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SessionStateChanged__ctor_m8E04BB6766439BA455F9C808171BD791230496D8 (SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___method1);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___method1))
	{
		bool isOpen = parameterCount == 4;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___method1))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5_Open;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
		__this->___method_code_6 = (intptr_t)__this->___m_target_2;
	}
	__this->___extra_arg_5 = (intptr_t)&SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5_Multicast;
}
// System.Void UnityEngine.Analytics.AnalyticsSessionInfo/SessionStateChanged::Invoke(UnityEngine.Analytics.AnalyticsSessionState,System.Int64,System.Int64,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5 (SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* __this, int32_t ___sessionState0, int64_t ___sessionId1, int64_t ___sessionElapsedTime2, bool ___sessionChanged3, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, int32_t, int64_t, int64_t, bool, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___sessionState0, ___sessionId1, ___sessionElapsedTime2, ___sessionChanged3, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_Multicast(IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* __this, String_t* ___token0, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* currentDelegate = reinterpret_cast<IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, ___token0, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_Open(IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* __this, String_t* ___token0, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___token0, method);
}
void IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_OpenStaticInvoker(IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* __this, String_t* ___token0, const RuntimeMethod* method)
{
	InvokerActionInvoker1< String_t* >::Invoke(__this->___method_ptr_0, method, NULL, ___token0);
}
void IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_ClosedStaticInvoker(IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* __this, String_t* ___token0, const RuntimeMethod* method)
{
	InvokerActionInvoker2< RuntimeObject*, String_t* >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2, ___token0);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395 (IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* __this, String_t* ___token0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(char*);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Marshaling of parameter '___token0' to native representation
	char* ____token0_marshaled = NULL;
	____token0_marshaled = il2cpp_codegen_marshal_string(___token0);

	// Native function invocation
	il2cppPInvokeFunc(____token0_marshaled);

	// Marshaling cleanup of parameter '___token0' native representation
	il2cpp_codegen_marshal_free(____token0_marshaled);
	____token0_marshaled = NULL;

}
// System.Void UnityEngine.Analytics.AnalyticsSessionInfo/IdentityTokenChanged::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void IdentityTokenChanged__ctor_m1970F8BEEDAA84A8FC5ABB973C0DB62FA2AA8312 (IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___method1);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___method1))
	{
		bool isOpen = parameterCount == 1;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___method1))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_Open;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		bool isOpen = parameterCount == 0;
		if (isOpen)
		{
			__this->___invoke_impl_1 = (intptr_t)&IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_Open;
		}
		else
		{
			__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
			__this->___method_code_6 = (intptr_t)__this->___m_target_2;
		}
	}
	__this->___extra_arg_5 = (intptr_t)&IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_Multicast;
}
// System.Void UnityEngine.Analytics.AnalyticsSessionInfo/IdentityTokenChanged::Invoke(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9 (IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* __this, String_t* ___token0, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___token0, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UpdatedEventHandler_Invoke_m4D496F648FD908A8537A35C4A94CBB44294D6D50_inline (UpdatedEventHandler_tB0D5A5BA322FE093894992C29DCF51E7E12579C4* __this, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_Invoke_m7126A54DACA72B845424072887B5F3A51FC3808E_inline (Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* __this, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void SessionStateChanged_Invoke_mB9195B30A226CB3E53E470C24FD31E039E5BB4F5_inline (SessionStateChanged_t1180FB66E702B635CAD9316DC661D931277B2A0C* __this, int32_t ___sessionState0, int64_t ___sessionId1, int64_t ___sessionElapsedTime2, bool ___sessionChanged3, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, int32_t, int64_t, int64_t, bool, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___sessionState0, ___sessionId1, ___sessionElapsedTime2, ___sessionChanged3, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void IdentityTokenChanged_Invoke_m22D3DA825F0D6E701D050EFA3D35E84DFAC7F8D9_inline (IdentityTokenChanged_tE8CB0DAB5F6E640A847803F582E6CB6237742395* __this, String_t* ___token0, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___token0, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_3_Invoke_mB1AE88F5C5FE161C85EA4A58D5CC535721E01B21_gshared_inline (Action_3_t4730167C8E7EB19F1E0034580790A915D549F6CB* __this, bool ___arg10, bool ___arg21, int32_t ___arg32, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, bool, bool, int32_t, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___arg10, ___arg21, ___arg32, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Action_1_Invoke_m69C8773D6967F3B224777183E24EA621CE056F8F_gshared_inline (Action_1_t10DCB0C07D0D3C565CEACADC80D1152B35A45F6C* __this, bool ___obj0, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, bool, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___obj0, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
