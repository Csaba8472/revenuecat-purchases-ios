using System;
using Foundation;
using ObjCRuntime;
using StoreKit;

namespace Binding
{
	// @interface SwiftFrameworkProxy : NSObject
	[BaseType (typeof(NSObject))]
	interface SwiftFrameworkProxy
	{
		// -(void)initForApiKey:(NSString * _Nonnull)apiKey __attribute__((objc_method_family("none")));
		[Export ("initForApiKey:")]
		void InitForApiKey (string apiKey);

		// -(void)getOfferingsWithClosure:(void (^ _Nonnull)(XRCOffering * _Nonnull, NSError * _Nullable))closure;
		[Export ("getOfferingsWithClosure:")]
		void GetOfferingsWithClosure (Action<XRCOffering, NSError> closure);

		// -(void)makePurchaseWithPackage:(XRCPackage * _Nonnull)package entitlementId:(NSString * _Nonnull)entitlementId closure:(void (^ _Nonnull)(BOOL))closure;
		[Export ("makePurchaseWithPackage:entitlementId:closure:")]
		void MakePurchaseWithPackage (XRCPackage package, string entitlementId, Action<bool> closure);

		// -(void)restorePurchaseWithEntitlementId:(NSString * _Nonnull)entitlementId closure:(void (^ _Nonnull)(BOOL))closure;
		[Export ("restorePurchaseWithEntitlementId:closure:")]
		void RestorePurchaseWithEntitlementId (string entitlementId, Action<bool> closure);

		// -(void)identifyUserWithUid:(NSString * _Nonnull)uid closure:(void (^ _Nonnull)(BOOL))closure;
		[Export ("identifyUserWithUid:closure:")]
		void IdentifyUserWithUid (string uid, Action<bool> closure);
	}

	// @interface XRCOffering
	[BaseType(typeof(NSObject))]
	interface XRCOffering
	{
		// @property (copy, nonatomic) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull serverDescription;
		[Export ("serverDescription")]
		string ServerDescription { get; set; }

		// @property (copy, nonatomic) NSArray<RCPackage *> * _Nonnull availablePackages;
		[Export ("availablePackages", ArgumentSemantic.Copy)]
		XRCPackage[] AvailablePackages { get; set; }

		// @property (nonatomic, strong) RCPackage * _Nullable lifetime;
		[NullAllowed, Export ("lifetime", ArgumentSemantic.Strong)]
		XRCPackage Lifetime { get; set; }

		// @property (nonatomic, strong) RCPackage * _Nullable annual;
		[NullAllowed, Export ("annual", ArgumentSemantic.Strong)]
		XRCPackage Annual { get; set; }

		// @property (nonatomic, strong) RCPackage * _Nullable sixMonth;
		[NullAllowed, Export ("sixMonth", ArgumentSemantic.Strong)]
		XRCPackage SixMonth { get; set; }

		// @property (nonatomic, strong) RCPackage * _Nullable threeMonth;
		[NullAllowed, Export ("threeMonth", ArgumentSemantic.Strong)]
		XRCPackage ThreeMonth { get; set; }

		// @property (nonatomic, strong) RCPackage * _Nullable twoMonth;
		[NullAllowed, Export ("twoMonth", ArgumentSemantic.Strong)]
		XRCPackage TwoMonth { get; set; }

		// @property (nonatomic, strong) RCPackage * _Nullable monthly;
		[NullAllowed, Export ("monthly", ArgumentSemantic.Strong)]
		XRCPackage Monthly { get; set; }

		// @property (nonatomic, strong) RCPackage * _Nullable weekly;
		[NullAllowed, Export ("weekly", ArgumentSemantic.Strong)]
		XRCPackage Weekly { get; set; }
	}

	// @interface XRCPackage
	[BaseType(typeof(NSObject))]
	interface XRCPackage
	{
		// @property (copy, nonatomic) NSString * _Nonnull identifier;
		[Export ("identifier")]
		string Identifier { get; set; }

		// @property (nonatomic) int packageType;
		[Export ("packageType")]
		int PackageType { get; set; }

		// @property (nonatomic, strong) SKProduct * _Nonnull product;
		[Export ("product", ArgumentSemantic.Strong)]
		SKProduct Product { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull localizedPriceString;
		[Export ("localizedPriceString")]
		string LocalizedPriceString { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull localizedIntroductoryPriceString;
		[Export ("localizedIntroductoryPriceString")]
		string LocalizedIntroductoryPriceString { get; set; }
	}
}
