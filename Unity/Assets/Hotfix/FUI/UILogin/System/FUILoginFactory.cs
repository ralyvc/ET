﻿using System.Threading.Tasks;
using ETModel;
using FairyGUI;

namespace ETHotfix
{
	/// <summary>
	/// 工厂，每种UI做一个工厂方法，在这里创建FUI
	/// </summary>
    [FUIFactory(FUIType.Login)]
    public class FUILoginFactory : IFUIFactory
    {
        public async ETTask<FUI> Create()
        {
	        await Task.CompletedTask;
	        
	        // 可以同步或者异步加载,异步加载需要搞个转圈圈,这里为了简单使用同步加载
	        // await ETModel.Game.Scene.GetComponent<FUIPackageComponent>().AddPackageAsync(FUIType.Login);
	        ETModel.Game.Scene.GetComponent<FUIPackageComponent>().AddPackage(FUIType.Login);
	        
	        FUI fui = ComponentFactory.Create<FUI, string, GObject>(FUIType.Login, UIPackage.CreateObject(FUIType.Login, FUIType.Login));
	        
	        // 这里可以根据UI逻辑的复杂度关联性，拆分成多个小组件来写逻辑,这里逻辑比较简单就只使用一个组件了
	        fui.AddComponent<FUILoginComponent>();
	        
	        return fui;
        }

	    public void Remove()
	    {
		    ETModel.Game.Scene.GetComponent<FUIPackageComponent>().RemovePackage(FUIType.Login);
	    }
    }
}