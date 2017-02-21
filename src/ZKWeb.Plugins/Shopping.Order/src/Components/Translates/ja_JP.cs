﻿using System.Collections.Generic;
using ZKWeb.Localize;
using ZKWebStandard.Extensions;
using ZKWebStandard.Ioc;

namespace ZKWeb.Plugins.Shopping.Order.src.Components.Translates {
	/// <summary>
	/// 日本语翻译
	/// </summary>
	[ExportMany, SingletonReuse]
	public class ja_JP : ITranslateProvider {
		private static HashSet<string> Codes = new HashSet<string>() { "ja-JP" };
		private static Dictionary<string, string> Translates = new Dictionary<string, string>()
		{
			{ "Order", "注文" },
			{ "OrderManage", "注文管理" },
			{ "Order management for ec site", "オンラインショッピングサイトが使う注文管理機能" },
			{ "Buynow", "今すぐ買う" },
			{ "AddToCart", "カートに入れる" },
			{ "Cart", "カート" },
			{ "The product you are try to purchase does not exist.",
				"購入しようとする商品は存在しません。" },
			{ "The product you are try to purchase does not purchasable.",
				"購入しようとする商品は現在は購入できません" },
			{ "Order count must larger than 0", "注文数は０以上でなければなりません" },
			{ "OrderSettings", "注文設定" },
			{ "BuynowCartProductExpiresDays", "すぐに買うカート内の商品の有効日数" },
			{ "NormalCartProductExpiresDays", "普通のカート内の商品の有効日数" },
			{ "AutoConfirmOrderAfterDays", "注文の自動確認日数" },
			{ "AllowAnonymousVisitorCreateOrder", "匿名利用者からの注文を許可する" },
			{ "Create order require user logged in", "注文するためにはログインが必要" },
			{ "ProductUnitPrice", "商品の単価" },
			{ "ProductTotalPrice", "商品の合計価格" },
			{ "LogisticsCost", "送料" },
			{ "Create order contains multi currency is not supported",
				"一つ以上の通貨が使われる注文を作成することはできません" },
			{ "Add product to cart success",
				"商品をカートに入れました" },
			{ "Total products", "合計商品数" },
			{ "Product total price", "商品の合計価格" },
			{ "Close", "关闭" },
			{ "Checkout >>>", "チェックアウト >>>" },
			{ "Order product unit price must not be negative", "商品の単価は負であってはなりません" },
			{ "Order cost must larger than 0", "注文の価格は０以上でなければなりません" },
			{ "Cart <em>[0]</em> products", "カート<em>[0]</em>件" },
			{ "<em>[0]</em> Products", "合計商品数<em>[0]</em>" },
			{ "Total <em>[0]</em>", "合計<em>[0]</em>" },
			{ "Cart is empty", "カートは空です、商品を入れてください。" },
			{ "Recently add to cart", "最近カートに追加した商品" },
			{ "Delete Successfully", "削除に成功しました" },
			{ "ShippingAddress", "お届け先の住所" },
			{ "Address/Name/Tel", "アドレス/名前/電話" },
			{ "ZipCode", "郵便番号" },
			{ "DetailedAddress", "詳細のアドレス" },
			{ "Fullname", "フルネーム" },
			{ "TelOrMobile", "電話/携帯電話" },
			{ "SubmitOrder", "注文する" },
			{ "Calculating...", "計算中..." },
			{ "Products total count: <em>0</em>", "商品数合計: <em>0</em>" },
			{ "Products total price: <em>0</em>", "商品価格合計: <em>0</em>" },
			{ "Shipping Address:", "お届け先の住所:" },
			{ "Use new address", "新しいアドレスを使う" },
			{ "Manage shipping address", "お届け先の住所を管理する" },
			{ "Check this will save or add shipping address",
				"ここをチェックすると入力した住所を保存できます" },
			{ "Save shipping address", "お届け先の住所を保存する" },
			{ "OrderComment", "注文コメント" },
			{ "Logistics:", "配送方法:" },
			{ "Logistics([0]):", "配送方法([0]):" },
			{ "PaymentApi:", "支払方法:" },
			{ "OrderTransaction", "注文取引" },
			{ "Order Comment:", "注文コメント:" },
			{ "Please select the products you want to purchase", "購入したい商品を選択してください" },
			{ "Selected logistics is not available for this seller", "この販売者は選択した配送方法を利用できません" },
			{ "Please select logistics", "配送方法を選択してください" },
			{ "Please select payment api", "支払方法を選択してください" },
			{ "AutoCancelOrderAfterDays", "自動的キャンセルを引き起こす未払い日数" },
			{ "StockReductionMode", "在庫削減モード" },
			{ "NoReduction", "減らさない" },
			{ "AfterCreateOrder", "注文を作成した後に減らす" },
			{ "AfterOrderPaid", "支払いが成功した後に減らす" },
			{ "Order contains product that not exist or deleted", "注文は存在しないまたは削除済みの商品を含めています" },
			{ "Insufficient stock of product [{0}]", "商品[{0}]は在庫不足です" },
			{ "Order contains real products, please select a logistics",
				"注文は物理的な商品を含めているため、配送方法を選択してください" },
			{ "Please provide detailed address", "詳細なアドレスを入力してください" },
			{ "Please provide receiver name", "荷受人の名前を入力してください" },
			{ "Please provide receiver tel or mobile", "荷受人の電話または携帯番号を入力してください" },
			{ "To create order please login first", "注文を作成するためにまずログインしてください" },
			{ "Selected logistics is not allowed to use", "選択した配送方法は使用できません、他の配送方法を選んでください" },
			{ "Selected payment api is not allowed to use", "選択した支払い方法は使用できません、他の支払い方法を選んでください" },
			{ "MergedOrderTransaction", "注文合併取引" },
			{ "Order not found", "注文が存在しません" },
			{ "Unknow order state: [0]", "未知の注文状態: [0]" },
			{ "Order Checkout", "注文決済" },
			{ "Order successfully created, please continue to pay", "注文は正常に作成されました、引き続きお支払いください" },
			{ "Merged transaction successfully created, please continue to pay", "統合された支払いが正常に作成されました、引き続きお支払いください" },
			{ "You have paid successful, please wait for seller delivery", "支払いが成功しました、商品の配送を待ってください" },
			{ "You have paid successful, please check following orders", "支払いが成功しました、以下の注文をチェックしてください" },
			{ "All goods shipped, please confirm order after receipt all goods", "すべての商品が出荷されました、受け取った後に注文を確認してください" },
			{ "Order is successed, thank you for your patronage", "注文は成功しました、ご愛顧いただきありがとうございます" },
			{ "Order is canceled", "注文がキャンセルされました" },
			{ "Order is obsoleted", "注文が中止されました" },
			{ "OrderSerial", "注文番号" },
			{ "OrderAmount", "注文金額" },
			{ "PaymentAmount", "支払金額" },
			{ "Pay with [0]", "[0]で支払う" },
			{ "Redirecting to order details page......", "注文の詳細ページにリダイレクトします……" },
			{ "Redirecting to order list page......", "注文の一覧ページにリダイレクトします……" },
			{ "RemarkFlags", "備考バナー" },
			{ "Serial/Remark", "番号/備考" },
			{ "Buyer", "購入者" },
			{ "Gray", "灰色" },
			{ "Red", "赤色" },
			{ "Yellow", "黄色" },
			{ "Green", "緑色" },
			{ "Blue", "青色" },
			{ "Purple", "紫色" },
			{ "OrderProducts", "注文した商品" },
			{ "Quantity", "数" },
			{ "ShippedQuantity", "出荷済みの数" },
			{ "ThisDeliveryQuantity", "今回の出荷数" },
			{ "Cost", "金額" },
			{ "TotalCost", "総金額" },
			{ "OrderPricePart", "注文価格の一部" },
			{ "SellerOrder", "販売者に属する注文" },
			{ "BuyerOrder", "購入者に属する注文" },
			{ "WaitingBuyerPay", "支払い待ち" },
			{ "WaitingSellerDeliveryGoods", "配送待ち" },
			{ "WaitingBuyerConfirm", "配送済み" },
			{ "OrderSuccess", "注文完了" },
			{ "OrderCancelled", "注文キャンセル" },
			{ "OrderInvalid", "注文中止" },
			{ "DeliveryRecords", "配送履歴" },
			{ "OrderRecords", "注文履歴" },
			{ "ReleatedTransactions", "関連取引" },
			{ "OrderComments", "注文コメント" },
			{ "Order Informations", "注文情報" },
			{ "You're using secured paid, please confirm transaction on payment platform after received goods",
				"あなたは担保付き取引を使用しています、商品を受け取った後は決済サイトで荷物の受取を確認してください" },
			{ "Buyer is using secured paid, please tell the buyer confirm transaction on payment platform after received goods",
				"購入者は担保付き取引を使用しています、決済サイトで荷物の受取を確認する必要があることを購入者にお知らせください" },
			{ "Releated transaction contains error: {0}", "関連取引のエラー: {0}" },
			{ "Copy shipping address to clipboard", "配送先住所をコピー" },
			{ "BuyerComment", "購入者コメント" },
			{ "SellerComment", "販売者コメント" },
			{ "More", "もっと" },
			{ "OrderLogistics", "配送方法" },
			{ "Order not payable because it's not waiting buyer pay",
				"注文は支払い待ちではありません" },
			{ "Order not payable because no payable releated transactions",
				"注文が関連する取引の中で支払いできる取引は存在しません" },
			{ "Order not cancellable because it's not waiting buyer pay",
				"注文は支払い待ちではないため、キャンセルができません" },
			{ "Order not cancellable because some releated transaction already paid",
				"注文が関連する取引の中で支払い済みの取引が存在するため、キャンセルができません" },
			{ "Order can't be confirmed because it's not waiting buyer confirm",
				"注文の配送がまだ完了していないため、受取の確認ができません" },
			{ "Order can't edit cost because it's not waiting buyer pay",
				"注文は支払い待ちではないため、価格を編集できません" },
			{ "Order can't edit cost because some releated transaction paid or realized",
				"注文が関連する取引の中で支払い済みまたは提出済みの取引が存在するため、価格を編集できません" },
			{ "Order can't edit shipping address because it's not waiting buyer pay or waiting seller send goods",
				"注文は支払い待ちまたは配送待ちではないため、配送先を編集できません" },
			{ "Order can't send goods because it's not waiting seller send goods", "注文は配送待ちではありません" },
			{ "Order already invalid", "注文はすでに中止されました" },
			{ "Order already cancelled", "注文はすでにキャンセルされました" },
			{ "Order can't be paid because it's not waiting buyer pay",
				"注文は支払い待ちではないため、支払い済みに切り替わることができません" },
			{ "Order can't be paid because not all releated transaction paid",
				"注文が関連する取引の中で未払いの取引が存在するため、支払い済みに切り替わることができません"},
			{ "Order can't be shipped because not waiting seller send goods",
				"注文は配送待ちではないため、配送済みに切り替わることができません" },
			{ "Order can't be shipped because not all goods shipped",
				"注文した商品はまだ全部配送していません、配送済みに切り替わることができません" },
			{ "Order can't be success because not waiting buyer confirm",
				"注文は配送済みではないため、注文完了に切り替わることができません" },
			{ "No payable transaction releated to this order", "注文が関連する取引の中で支払いできる取引は存在しません" },
			{ "PayNow", "支払いを継続する" },
			{ "CancelOrder", "注文キャンセル" },
			{ "ConfirmOrder", "受取確認" },
			{ "EditCost", "価格編集" },
			{ "EditShippingAddress", "配送先編集" },
			{ "DeliveryGoods", "配送" },
			{ "ConfirmInsteadOfBuyer", "代わりに受取確認" },
			{ "SetInvalid", "中止" },
			{ "OrderState", "注文状態" },
			{ "OrderActions", "注文操作" },
			{ "OriginalTotalCost", "オリジナル総金額" },
			{ "DeliverySerial", "配送番号" },
			{ "LogisticsSerial", "配送票番号" },
			{ "DeliveryOperator", "荷送人" },
			{ "DeliveryTime", "配送時刻" },
			{ "View Transaction", "取引の詳細" },
			{ "View Delivery", "配送の詳細" },
			{ "To delete product please change the quantity to zero, and check transaction amount after modification",
				"商品を削除する際は数を0に設定してください、価格を変更したあとは取引の金額もチェックしてください" },
			{ "Order total cost", "注文総金額" },
			{ "Order not exist", "注文が存在しません" },
			{ "Order product not exist", "注文した商品が存在しません" },
			{ "Can't delete all products in the order", "注文が含めたすべての商品を削除することができまえん" },
			{ "Amount changed by edit order cost, previous value is {0}", "取引金額は注文金額と一緒に変更されました、前値は{0}" },
			{ "Order total cost changed, previous value is {0}", "注文総金額が変更されました、前値は{0}" },
			{ "ManuallyEditPrice", "価格編集" },
			{ "Order shipping address changed, previous value is {0}", "配送先が変更されました、前値は{0}" },
			{ "Child transactions amount changed by edit order cost, this merge transaction should be aborted",
				"注文金額の変更によりサブ取引の金額が変動したため、この合併取引は中止されました" },
			{ "Child transaction {0} process waiting paying standalone, this merge transaction should be aborted",
				"サブ取引({0})は単独で支払い待ちを処理したため、この合併取引は中止されました" },
			{ "Child transaction {0} process secured paid standalone, this merge transaction should be aborted",
				"サブ取引({0})は単独で担保付き取引の支払い済みを処理したため、この合併取引は中止されました" },
			{ "Child transaction {0} process success standalone, this merge transaction should be aborted",
				"サブ取引({0})は単独で取引成功を処理したため、この合併取引は中止されました" },
			{ "Child transaction {0} aborted, this merge transaction should be aborted too",
				"サブ取引({0})が中止されたため、この合併取引は中止されました" },
			{ "Order secured paid from transaction, serial is {0}", "注文は担保付き取引を使用して支払い済みになりました、取引通番は{0}" },
			{ "Order is paid", "注文は支払い済みになりました" },
			{ "Can't process order paid, reason is {0}", "注文の支払い済みを処理できません、原因は{0}" },
			{ "All goods under order is shipped", "注文は配送済みになりました" },
			{ "Can't process order shipped, reason is {0}", "注文の配送済みを処理できません、原因は{0}" },
			{ "Order is successed", "注文は成功に完了しました" },
			{ "Can't process order successed, reason is {0}", "注文の完了を処理できません、原因んは{0}" },
			{ "Order paid from transaction, serial is {0}", "注文は支払い済みになりました、取引通番は{0}" },
			{ "Order confirmed from payment platform after secured paid, serial is {0}",
				"担保付き取引を使用した注文は決済サイトで受取を確認されました、取引通番{0}" },
			{ "Merged Order Checkout", "注文合併決済" },
			{ "Back to order list", "注文一覧に戻る" },
			{ "Order Serial: {0}", "注文番号: {0}" },
			{ "Add comment here then click submit", "コメントをここに入力したあと送信を押してください" },
			{ "Reason can't be empty", "理由を入力してください" },
			{ "Order become invalid, reason is {0}", "注文が中止されました、理由は{0}" },
			{ "Can't set order invalid, reason is {0}", "注文を中止できません、原因は{0}" },
			{ "SetInvalidReason", "中止する理由" },
			{ "The reason of set order invalid, must provide", "注文を中止する理由、必須" },
			{ "Set order invalid failed, please check order records", "注文を中止できません、履歴をチェックしてください" },
			{ "Set order invalid success", "注文を中止しました" },
			{ "Order cancelled, reason is {0}", "注文がキャンセルされました、理由は{0}" },
			{ "Can't cancel order, reason is {0}", "注文をキャンセルできません、原因は{0}" },
			{ "CancelReason", "キャンセルする理由" },
			{ "The reason of cancel order, must provide", "注文をキャンセル理由、必須" },
			{ "Cancel order failed, please check order records", "注文をキャンセルできません、履歴をチェックしてください" },
			{ "Cancel order success", "注文をキャンセルしました" },
			{ "Can't delivery product that not exists in order", "注文にない商品を出荷することができません" },
			{ "Invalid delivery count", "出荷数が間違っています" },
			{ "Delivery count can't be larger than unshipped count", "出荷数が未出荷数より多いです" },
			{ "No products to be delivery", "出荷する商品がありません" },
			{ "The shipping address is \"{0}\", and buyer want to use logistics \"{1}\"",
				"購入者の配送先は\"{0}\"、希望する配送方法は\"{1}\"" },
			{ "Order only contains virtual products, if you have something to buyer please use comment",
				"注文はバーチャル商品しか含めていません、購入者になにかを送りたい場合はコメントを利用してください" },
			{ "Please provide logistics serial (invoice no)", "请提供物流编号(快递单编号)" },
			{ "Buyer confirm all goods shipped, order should be success",
				"購入者は受取を確認しました、注文は成功に完了しました" },
			{ "Seller confirm order insetead of buyer, order should be success",
				"販売者は購入者の代わりに受取を確認しました、注文は成功に完了しました" },
			{ "Can't confirm order, reason is {0}", "受取を確認できません、原因は{0}" },
			{ "Thank you! Before you confirm receipt", "ご愛顧ありがとうございました！受取を確認する前に" },
			{ "Make sure you have received all the goods", "すべての商品を受け取ったことを確認してください" },
			{ "Confirm receipt of the goods in good condition and meet your requirements",
				"すべての商品の状態が良好で、あなたの要求を満たしていることを確認してください" },
			{ "If you are using a secured transaction payment, you will also need to go to the payment platform (such as Alipay) to confirm receipt",
				"担保付き取引を使用した場合は、決済サイト（Paypalなど）で荷物の受取を確認してください" },
			{ "Thank you for your presence, welcome to buy our products again!",
				"ご愛顧ありがとうございました，またのご来店を歓迎いたします！" },
			{ "You are trying to confirm the goods receipt instead of the buyer, please confirm before submitting",
				"あなたは購入者の代わりに受取を確認しようとしています、送信する前に" },
			{ "Does the buyer not acknowledge receipt within the specified time?",
				"購入者は一定時間を経過しても受取を確認しませんでしたか？" },
			{ "You can also enable automatically confirm receipt feature form the order settings",
				"注文設定から確認自動化の機能を有効にすることもできます" },
			{ "Confirm order failed, please check order records",
				"受取の確認に失敗しました、履歴をチェックしてください" },
			{ "Confirm order success", "受取の確認に成功しました" },
			{ "Auto confirm order after {0} days", "{0}日を経過しても受取を確認しないため、自動的に確認します" },
			{ "Auto cancel order after {0} days unpaid", "{0}日を経過しても支払わないため、自動的にキャンセルします" },
			{ "MergePayment", "一度に支払う" },
			{ "Please select orders to merge payment", "一度に支払い注文を選んでください" },
			{ "Sure to merge following order's payment?", "以下の注文を一度に支払いますか？" },
			{ "Some order not exists", "一部の注文が存在しません" },
			{ "Merge payment required atleast 2 orders", "一度に支払う注文は少なくとも二つが必要です" },
			{ "Some order is not payable", "一部の注文が支払可能ではありません" },
			{ "New merged transaction has created, this merge transaction should be aborted",
				"新しい合併取引を作成したため、この古いほうの取引は中止されました" },
			{ "CartPage", "ショッピングカートページ" },
			{ "CartContents", "カート内容" },
			{ "MiniCartMenu", "ミニカートメニュー" },
			{ "ProductPurchaseButtons", "商品購入ボタン" }
		};

		public bool CanTranslate(string code) {
			return Codes.Contains(code);
		}

		public string Translate(string text) {
			return Translates.GetOrDefault(text);
		}
	}
}
