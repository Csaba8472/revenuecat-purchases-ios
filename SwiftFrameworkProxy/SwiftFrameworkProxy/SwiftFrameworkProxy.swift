//
//  SwiftFrameworkProxy.swift
//  SwiftFrameworkProxy
//
//  Created by Csaba Huszar on 2021. 01. 26..
//

import Foundation
import Purchases

@objc(XRCPackageTypes)
public enum XRCPackageTypes: NSInteger {
    case RCPackageTypeUnknown = -2
    case RCPackageTypeCustom
    case RCPackageTypeLifetime
    case RCPackageTypeAnnual
    case RCPackageTypeSixMonth
    case RCPackageTypeThreeMonth
    case RCPackageTypeTwoMonth
    case RCPackageTypeMonthly
    case RCPackageTypeWeekly
}

@objc(XRCPackage)
public class XRCPackage : Purchases.Package {
    
    var _identifier: String = ""
    
    @objc
    public override var identifier: String {
         get {
             return _identifier
         }
         set {
             self._identifier = newValue
         }
     }
    
    var _packageType: Purchases.PackageType = Purchases.PackageType.unknown
    
    @objc
    public override var packageType: Purchases.PackageType {
         get {
             return _packageType
         }
         set {
             self._packageType = newValue
         }
     }
    
    
    var _product: SKProduct?
    
    @objc
    public override var product: SKProduct {
         get {
             return _product!
         }
         set {
             self._product = newValue
         }
     }
    
    var _localizedPriceString: String = ""
    
    @objc
    public override var localizedPriceString: String {
         get {
             return _localizedPriceString
         }
         set {
             self._localizedPriceString = newValue
         }
     }
    
    var _localizedIntroductoryPriceString: String = ""
    
    @objc
    public override var localizedIntroductoryPriceString: String {
         get {
             return _localizedIntroductoryPriceString
         }
         set {
             self._localizedIntroductoryPriceString = newValue
         }
     }
}

@objc(XRCOffering)
public class XRCOffering : Purchases.Offering {
    

    var _identifier: String = ""

    @objc
    public override var identifier: String {
         get {
             return _identifier
         }
         set {
             self._identifier = newValue
         }
     }
    
    var _serverDescription: String = ""
    
    @objc
    public override var serverDescription: String {
         get {
             return _serverDescription
         }
         set {
             self._serverDescription = newValue
         }
     }
    
    var _availablePackages: Array<Purchases.Package> = []
    
    @objc
    public override var availablePackages: Array<Purchases.Package> {
         get {
             return _availablePackages
         }
         set {
             self._availablePackages = newValue
         }
     }
    
    
    var _lifetime: Purchases.Package?
    
    @objc
    public override var lifetime: Purchases.Package? {
         get {
             return _lifetime
         }
         set {
             self._lifetime = newValue
         }
     }
    
    
    var _annual: Purchases.Package?
    
    @objc
    public override var annual: Purchases.Package? {
         get {
             return _annual
         }
         set {
             self._annual = newValue
         }
     }
    
    var _sixMonth: Purchases.Package?
    
    @objc
    public override var sixMonth: Purchases.Package? {
         get {
             return _sixMonth
         }
         set {
             self._sixMonth = newValue
         }
     }
    
    var _threeMonth: Purchases.Package?
    
    @objc
    public override var threeMonth: Purchases.Package? {
         get {
             return _threeMonth
         }
         set {
             self._threeMonth = newValue
         }
     }
    
    
    var _twoMonth: Purchases.Package?
    
    @objc
    public override var twoMonth: Purchases.Package? {
         get {
             return _twoMonth
         }
         set {
             self._twoMonth = newValue
         }
     }
    
    var _monthly: Purchases.Package?
    
    @objc
    public override var monthly: Purchases.Package? {
         get {
             return _monthly
         }
         set {
             self._monthly = newValue
         }
     }

    var _weekly: Purchases.Package?

    @objc
    public override var weekly: Purchases.Package? {
         get {
             return _weekly
         }
         set {
             self._weekly = newValue
         }
     }
    
}


@objc(SwiftFrameworkProxy)
public class SwiftFrameworkProxy : NSObject {

    @objc
    public func initFor(apiKey: String) {
        Purchases.debugLogsEnabled=true
        Purchases.configure(withAPIKey: apiKey)
    }
    
    @objc
    public func getOfferings(closure: @escaping (XRCOffering, Error?)->Void) {
        Purchases.shared.offerings { (offerings, error) in
            
            let o = XRCOffering()
            
            if let currentOffering = offerings?.current {
                o.identifier = currentOffering.identifier
                o.serverDescription = currentOffering.serverDescription
                for aPackage in currentOffering.availablePackages {
                    o.availablePackages.append(aPackage)
                }
                o.lifetime = currentOffering.lifetime
                o.annual = currentOffering.annual
                o.sixMonth = currentOffering.sixMonth
                o.threeMonth = currentOffering.threeMonth
                o.twoMonth = currentOffering.twoMonth
                o.monthly = currentOffering.monthly
                o.weekly = currentOffering.weekly

                closure(o, error)
            }else{
                closure(o, error)
            }
                
        }
    }
    
    @objc
    public func makePurchase(package: XRCPackage, entitlementId: String, closure: @escaping (Bool)->Void) {
        Purchases.shared.purchasePackage(package) { (transaction, purchaserInfo, error, bool) in
            
            if error != nil {
                closure(false)
                return
            }
            
            if ((purchaserInfo?.entitlements.active[entitlementId]) != nil) {
                closure(true)
            }else{
                closure(false);
            }
        }
    }
    
    @objc
    public func restorePurchase(entitlementId:String, closure: @escaping (Bool)->Void){
        Purchases.shared.restoreTransactions(){(purchaseInfo, error) in
            if error != nil {
                closure(false)
                return
            }
            if ((purchaseInfo?.entitlements.active[entitlementId]) != nil) {
                closure(true)
            }else{
                closure(false);
            }
        }
    }
    
    @objc
    public func identifyUser(uid:String, closure: @escaping (Bool)->Void){
        Purchases.shared.identify(uid) { (purchaserInfo, error) in
            if error != nil {
                closure(false)
            } else{
                closure(true)
            }
        }
    }
}
