//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;

#nullable enable

namespace Binding {
	[Register("SwiftFrameworkProxy", true)]
	public unsafe partial class SwiftFrameworkProxy : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("SwiftFrameworkProxy");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SwiftFrameworkProxy () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SwiftFrameworkProxy (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SwiftFrameworkProxy (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("getOfferingsWithClosure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetOfferingsWithClosure ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<RCOffering, NSError> closure)
		{
			if (closure == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (closure));
			BlockLiteral *block_ptr_closure;
			BlockLiteral block_closure;
			block_closure = new BlockLiteral ();
			block_ptr_closure = &block_closure;
			block_closure.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, closure);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getOfferingsWithClosure:"), (IntPtr) block_ptr_closure);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getOfferingsWithClosure:"), (IntPtr) block_ptr_closure);
			}
			block_ptr_closure->CleanupBlock ();
			
		}
		
		[Export ("identifyUserWithUid:closure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void IdentifyUserWithUid (string uid, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> closure)
		{
			if (uid == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (uid));
			if (closure == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (closure));
			var nsuid = NSString.CreateNative (uid);
			BlockLiteral *block_ptr_closure;
			BlockLiteral block_closure;
			block_closure = new BlockLiteral ();
			block_ptr_closure = &block_closure;
			block_closure.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, closure);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("identifyUserWithUid:closure:"), nsuid, (IntPtr) block_ptr_closure);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("identifyUserWithUid:closure:"), nsuid, (IntPtr) block_ptr_closure);
			}
			NSString.ReleaseNative (nsuid);
			block_ptr_closure->CleanupBlock ();
			
		}
		
		[Export ("initForApiKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InitForApiKey (string apiKey)
		{
			if (apiKey == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (apiKey));
			var nsapiKey = NSString.CreateNative (apiKey);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initForApiKey:"), nsapiKey);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initForApiKey:"), nsapiKey);
			}
			NSString.ReleaseNative (nsapiKey);
			
		}
		
		[Export ("makePurchaseWithClosure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void MakePurchaseWithClosure ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> closure)
		{
			if (closure == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (closure));
			BlockLiteral *block_ptr_closure;
			BlockLiteral block_closure;
			block_closure = new BlockLiteral ();
			block_ptr_closure = &block_closure;
			block_closure.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, closure);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("makePurchaseWithClosure:"), (IntPtr) block_ptr_closure);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("makePurchaseWithClosure:"), (IntPtr) block_ptr_closure);
			}
			block_ptr_closure->CleanupBlock ();
			
		}
		
		[Export ("restorePurchaseWithClosure:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RestorePurchaseWithClosure ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> closure)
		{
			if (closure == null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (closure));
			BlockLiteral *block_ptr_closure;
			BlockLiteral block_closure;
			block_closure = new BlockLiteral ();
			block_ptr_closure = &block_closure;
			block_closure.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, closure);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("restorePurchaseWithClosure:"), (IntPtr) block_ptr_closure);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("restorePurchaseWithClosure:"), (IntPtr) block_ptr_closure);
			}
			block_ptr_closure->CleanupBlock ();
			
		}
		
	} /* class SwiftFrameworkProxy */
}
