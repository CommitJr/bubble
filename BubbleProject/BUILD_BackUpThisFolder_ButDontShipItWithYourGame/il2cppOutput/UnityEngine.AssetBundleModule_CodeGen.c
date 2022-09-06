#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Void UnityEngine.AssetBundle::.ctor()
extern void AssetBundle__ctor_m12989CA081324BB49ED893BDA5E3B4E758D61410 (void);
// 0x00000002 UnityEngine.AssetBundle UnityEngine.AssetBundle::LoadFromFile_Internal(System.String,System.UInt32,System.UInt64)
extern void AssetBundle_LoadFromFile_Internal_mBADE7FF4DE42B855B626633622F8DE05820B4876 (void);
// 0x00000003 UnityEngine.AssetBundle UnityEngine.AssetBundle::LoadFromFile(System.String)
extern void AssetBundle_LoadFromFile_mFED01CCB7121612FD98DC6D79ECD08F58DADA275 (void);
// 0x00000004 T UnityEngine.AssetBundle::LoadAsset(System.String)
// 0x00000005 UnityEngine.Object UnityEngine.AssetBundle::LoadAsset(System.String,System.Type)
extern void AssetBundle_LoadAsset_m021FE0B52DD660E54AE4C225D9AE66147902B8FE (void);
// 0x00000006 UnityEngine.Object UnityEngine.AssetBundle::LoadAsset_Internal(System.String,System.Type)
extern void AssetBundle_LoadAsset_Internal_mD096392756815901FE982C1AF64DDF0846551433 (void);
// 0x00000007 UnityEngine.Object[] UnityEngine.AssetBundle::LoadAllAssets()
extern void AssetBundle_LoadAllAssets_m00E63EFF07B8E986754B7AFB3B8566B2B99C2241 (void);
// 0x00000008 UnityEngine.Object[] UnityEngine.AssetBundle::LoadAllAssets(System.Type)
extern void AssetBundle_LoadAllAssets_m0A8F41292C96F658A89B0E8D0ADB2E8395DD7F62 (void);
// 0x00000009 UnityEngine.Object[] UnityEngine.AssetBundle::LoadAssetWithSubAssets_Internal(System.String,System.Type)
extern void AssetBundle_LoadAssetWithSubAssets_Internal_m14AE2B2D7696182CBDF12087E8D3FEA867290DA8 (void);
// 0x0000000A System.String[] UnityEngine.AssetBundleManifest::GetAllAssetBundles()
extern void AssetBundleManifest_GetAllAssetBundles_m0B9B68B03401B23693582DFE66F7B10A8C80EE54 (void);
static Il2CppMethodPointer s_methodPointers[10] = 
{
	AssetBundle__ctor_m12989CA081324BB49ED893BDA5E3B4E758D61410,
	AssetBundle_LoadFromFile_Internal_mBADE7FF4DE42B855B626633622F8DE05820B4876,
	AssetBundle_LoadFromFile_mFED01CCB7121612FD98DC6D79ECD08F58DADA275,
	NULL,
	AssetBundle_LoadAsset_m021FE0B52DD660E54AE4C225D9AE66147902B8FE,
	AssetBundle_LoadAsset_Internal_mD096392756815901FE982C1AF64DDF0846551433,
	AssetBundle_LoadAllAssets_m00E63EFF07B8E986754B7AFB3B8566B2B99C2241,
	AssetBundle_LoadAllAssets_m0A8F41292C96F658A89B0E8D0ADB2E8395DD7F62,
	AssetBundle_LoadAssetWithSubAssets_Internal_m14AE2B2D7696182CBDF12087E8D3FEA867290DA8,
	AssetBundleManifest_GetAllAssetBundles_m0B9B68B03401B23693582DFE66F7B10A8C80EE54,
};
static const int32_t s_InvokerIndices[10] = 
{
	6663,
	8450,
	10767,
	0,
	2145,
	2145,
	6534,
	4075,
	2145,
	6534,
};
static const Il2CppTokenRangePair s_rgctxIndices[1] = 
{
	{ 0x06000004, { 0, 2 } },
};
extern const uint32_t g_rgctx_T_t8F5466E687C8861B9EA9A0932E573160D9356A57;
extern const uint32_t g_rgctx_T_t8F5466E687C8861B9EA9A0932E573160D9356A57;
static const Il2CppRGCTXDefinition s_rgctxValues[2] = 
{
	{ (Il2CppRGCTXDataType)1, (const void *)&g_rgctx_T_t8F5466E687C8861B9EA9A0932E573160D9356A57 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_T_t8F5466E687C8861B9EA9A0932E573160D9356A57 },
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_UnityEngine_AssetBundleModule_CodeGenModule;
const Il2CppCodeGenModule g_UnityEngine_AssetBundleModule_CodeGenModule = 
{
	"UnityEngine.AssetBundleModule.dll",
	10,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	1,
	s_rgctxIndices,
	2,
	s_rgctxValues,
	NULL,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
