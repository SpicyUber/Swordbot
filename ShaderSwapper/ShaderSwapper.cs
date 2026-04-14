using Microsoft.CodeAnalysis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: TargetFramework(".NETStandard,Version=v2.0", FrameworkDisplayName = ".NET Standard 2.0")]
[assembly: AssemblyCompany("ShaderSwapper")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0")]
[assembly: AssemblyProduct("ShaderSwapper")]
[assembly: AssemblyTitle("ShaderSwapper")]
[assembly: AssemblyVersion("1.0.0.0")]
[module: RefSafetyRules(11)]
namespace Microsoft.CodeAnalysis
{
    [CompilerGenerated]
    [Microsoft.CodeAnalysis.Embedded]
    internal sealed class EmbeddedAttribute : Attribute
    {
    }
}
namespace System.Runtime.CompilerServices
{
    [CompilerGenerated]
    [Microsoft.CodeAnalysis.Embedded]
    [AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
    internal sealed class RefSafetyRulesAttribute : Attribute
    {
        public readonly int Version;

        public RefSafetyRulesAttribute(int P_0)
        {
            Version = P_0;
        }
    }
}
namespace ShaderSwapper
{
    public static class ShaderSwapper
    {
        private const string PREFIX = "Stubbed";

        private const int PREFIX_LENGTH = 7;

        private static Object[] _ = Array.Empty<Object>();

        public static IEnumerator UpgradeStubbedShadersAsync(this AssetBundle assetBundle)
        {
            if ((Object)(object)assetBundle == (Object)null)
            {
                throw new ArgumentNullException("assetBundle");
            }
            AssetBundleRequest loadMaterials = assetBundle.LoadAllAssetsAsync<Material>();
            while (!((AsyncOperation)loadMaterials).isDone)
            {
                yield return null;
            }
            Object[] allMaterials = loadMaterials.allAssets;
            int materialCount = allMaterials.Length;
            if (materialCount <= 0)
            {
                yield break;
            }
            List<AsyncOperationHandle> list = new List<AsyncOperationHandle>(materialCount);
            for (int num = materialCount - 1; num >= 0; num--)
            {
                string name = ((Object)((Material)allMaterials[num]).shader).name;
                if (name.StartsWith("Stubbed"))
                {
                    list.Add(AsyncOperationHandle<IList<IResourceLocation>>.op_Implicit(Addressables.LoadResourceLocationsAsync((object)(name.Substring(7) + ".shader"), typeof(Shader))));
                }
                else
                {
                    materialCount--;
                    for (int i = num; i < materialCount; i++)
                    {
                        allMaterials[i] = allMaterials[i + 1];
                    }
                }
            }
            if (materialCount <= 0)
            {
                yield break;
            }
            AsyncOperationHandle<IList<AsyncOperationHandle>> loadResourceLocationsGroup = Addressables.ResourceManager.CreateGenericGroupOperation(list, false);
            while (!loadResourceLocationsGroup.IsDone)
            {
                yield return null;
            }
            List<IResourceLocation> list2 = new List<IResourceLocation>(materialCount);
            for (int num2 = materialCount - 1; num2 >= 0; num2--)
            {
                AsyncOperationHandle val = loadResourceLocationsGroup.Result[num2];
                IList<IResourceLocation> list3 = (IList<IResourceLocation>)((AsyncOperationHandle)(ref val)).Result;
                if (list3.Count > 0)
                {
                    list2.Add(list3[0]);
                }
                else
                {
                    materialCount--;
                    for (int j = materialCount - num2; j < materialCount; j++)
                    {
                        allMaterials[j] = allMaterials[j + 1];
                    }
                }
            }
            if (materialCount > 0)
            {
                AsyncOperationHandle<IList<Shader>> loadShaders = Addressables.LoadAssetsAsync<Shader>((IList<IResourceLocation>)list2, (Action<Shader>)null, false);
                while (!loadShaders.IsDone)
                {
                    yield return null;
                }
                int num3 = _.Length;
                Array.Resize(ref _, num3 + materialCount);
                for (int k = 0; k < materialCount; k++)
                {
                    SwapShader((Material)allMaterials[k], loadShaders.Result[k]);
                    _[num3 + k] = allMaterials[k];
                }
            }
        }

        public static IEnumerator UpgradeStubbedShaderAsync(Material material)
        {
            if ((Object)(object)material == (Object)null)
            {
                throw new ArgumentNullException("material");
            }
            string name = ((Object)material.shader).name;
            if (!name.StartsWith("Stubbed"))
            {
                yield break;
            }
            AsyncOperationHandle<IList<IResourceLocation>> loadResourceLocations = Addressables.LoadResourceLocationsAsync((object)(name.Substring(7) + ".shader"), typeof(Shader));
            while (!loadResourceLocations.IsDone)
            {
                yield return null;
            }
            if (loadResourceLocations.Result.Count > 0)
            {
                AsyncOperationHandle<Shader> loadShader = Addressables.LoadAssetAsync<Shader>(loadResourceLocations.Result[0]);
                while (!loadShader.IsDone)
                {
                    yield return null;
                }
                SwapShader(material, loadShader.Result);
                Array.Resize(ref _, _.Length + 1);
                _[_.Length - 1] = (Object)(object)material;
            }
        }

        [Obsolete("The asynchronous method UpgradeStubbedShadersAsync is heavily preferred.", false)]
        public static void UpgradeStubbedShaders(this AssetBundle assetBundle)
        {
            if ((Object)(object)assetBundle == (Object)null)
            {
                throw new ArgumentNullException("assetBundle");
            }
            Material[] array = assetBundle.LoadAllAssets<Material>();
            for (int i = 0; i < array.Length; i++)
            {
                UpgradeStubbedShader(array[i]);
            }
        }

        [Obsolete("The asynchronous method UpgradeStubbedShaderAsync is heavily preferred.", false)]
        public static void UpgradeStubbedShader(Material material)
        {
            //IL_0049: Unknown result type (might be due to invalid IL or missing references)
            //IL_004e: Unknown result type (might be due to invalid IL or missing references)
            //IL_0068: Unknown result type (might be due to invalid IL or missing references)
            //IL_006d: Unknown result type (might be due to invalid IL or missing references)
            if ((Object)(object)material == (Object)null)
            {
                throw new ArgumentNullException("material");
            }
            string name = ((Object)material.shader).name;
            if (name.StartsWith("Stubbed"))
            {
                IList<IResourceLocation> list = Addressables.LoadResourceLocationsAsync((object)(name.Substring(7) + ".shader"), typeof(Shader)).WaitForCompletion();
                if (list.Count > 0)
                {
                    SwapShader(material, Addressables.LoadAssetAsync<Shader>(list[0]).WaitForCompletion());
                    Array.Resize(ref _, _.Length + 1);
                    _[_.Length - 1] = (Object)(object)material;
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void SwapShader(Material material, Shader shader)
        {
            int renderQueue = material.renderQueue;
            material.shader = shader;
            material.renderQueue = renderQueue;
        }
    }
}

