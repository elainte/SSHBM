﻿
 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IBLLService
{
	public partial interface IBLLSession
    {
		IFW_AUDIT_RECORD_MANAGER IFW_AUDIT_RECORD_MANAGER {get;set;}

		IFW_GEO_NODE_MANAGER IFW_GEO_NODE_MANAGER {get;set;}

		IFW_GEO_NODE_CUST_MANAGER IFW_GEO_NODE_CUST_MANAGER {get;set;}

		IFW_GEO_TREE_MANAGER IFW_GEO_TREE_MANAGER {get;set;}

		IFW_GEO_TREE_LEVEL_MANAGER IFW_GEO_TREE_LEVEL_MANAGER {get;set;}

		IFW_MODULE_MANAGER IFW_MODULE_MANAGER {get;set;}

		IFW_MODULEPERMISSION_MANAGER IFW_MODULEPERMISSION_MANAGER {get;set;}

		IFW_OPERATELOG_MANAGER IFW_OPERATELOG_MANAGER {get;set;}

		IFW_PERMISSION_MANAGER IFW_PERMISSION_MANAGER {get;set;}

		IFW_ROLE_MANAGER IFW_ROLE_MANAGER {get;set;}

		IFW_ROLEPERMISSION_MANAGER IFW_ROLEPERMISSION_MANAGER {get;set;}

		IFW_USER_MANAGER IFW_USER_MANAGER {get;set;}

		IFW_USER_ASSIGN_MANAGER IFW_USER_ASSIGN_MANAGER {get;set;}

		IFW_USER_ROLE_MANAGER IFW_USER_ROLE_MANAGER {get;set;}

		IJF_Order_MANAGER IJF_Order_MANAGER {get;set;}

		IJF_Product_MANAGER IJF_Product_MANAGER {get;set;}

		IMST_ARTICLE_MANAGER IMST_ARTICLE_MANAGER {get;set;}

		IMST_ATTACHMENTS_MANAGER IMST_ATTACHMENTS_MANAGER {get;set;}

		IMST_CAR_MANAGER IMST_CAR_MANAGER {get;set;}

		IMST_CATALOG_MANAGER IMST_CATALOG_MANAGER {get;set;}

		IMST_CATEGORY_MANAGER IMST_CATEGORY_MANAGER {get;set;}

		IMST_COMPANY_MANAGER IMST_COMPANY_MANAGER {get;set;}

		IMST_COMPANY_MEM_MANAGER IMST_COMPANY_MEM_MANAGER {get;set;}

		IMST_MEMBER_MANAGER IMST_MEMBER_MANAGER {get;set;}

		IMST_MUSTSELL_MANAGER IMST_MUSTSELL_MANAGER {get;set;}

		IMST_MUSTSELL_DTL_MANAGER IMST_MUSTSELL_DTL_MANAGER {get;set;}

		IMST_MUSTSELL_PRD_MANAGER IMST_MUSTSELL_PRD_MANAGER {get;set;}

		IMST_POSITION_MANAGER IMST_POSITION_MANAGER {get;set;}

		IMST_PRD_MANAGER IMST_PRD_MANAGER {get;set;}

		IMST_PRD_CATE_MANAGER IMST_PRD_CATE_MANAGER {get;set;}

		IMST_PRD_IMG_MANAGER IMST_PRD_IMG_MANAGER {get;set;}

		IMST_RESUME_MANAGER IMST_RESUME_MANAGER {get;set;}

		IMST_RESUME_DTL_MANAGER IMST_RESUME_DTL_MANAGER {get;set;}

		IMST_SUPPLIER_MANAGER IMST_SUPPLIER_MANAGER {get;set;}

		ISET_COUNTRY_MANAGER ISET_COUNTRY_MANAGER {get;set;}

		ISET_NAVIGATION_ITEM_MANAGER ISET_NAVIGATION_ITEM_MANAGER {get;set;}

		ISET_REGION_MANAGER ISET_REGION_MANAGER {get;set;}

		ISYS_REF_MANAGER ISYS_REF_MANAGER {get;set;}

		ISYS_USERLOGIN_MANAGER ISYS_USERLOGIN_MANAGER {get;set;}

		ITG_Address_MANAGER ITG_Address_MANAGER {get;set;}

		ITG_BankCrad_MANAGER ITG_BankCrad_MANAGER {get;set;}

		ITG_Car_MANAGER ITG_Car_MANAGER {get;set;}

		ITG_fenxiaoConfig_MANAGER ITG_fenxiaoConfig_MANAGER {get;set;}

		ITG_jifenLog_MANAGER ITG_jifenLog_MANAGER {get;set;}

		ITG_order_MANAGER ITG_order_MANAGER {get;set;}

		ITG_pic_MANAGER ITG_pic_MANAGER {get;set;}

		ITG_product_MANAGER ITG_product_MANAGER {get;set;}

		ITG_productBrand_MANAGER ITG_productBrand_MANAGER {get;set;}

		ITG_productCate_MANAGER ITG_productCate_MANAGER {get;set;}

		ITG_productColor_MANAGER ITG_productColor_MANAGER {get;set;}

		ITG_QD_MANAGER ITG_QD_MANAGER {get;set;}

		ITG_redPaperLog_MANAGER ITG_redPaperLog_MANAGER {get;set;}

		ITG_review_MANAGER ITG_review_MANAGER {get;set;}

		ITG_SCproduct_MANAGER ITG_SCproduct_MANAGER {get;set;}

		ITG_Thing_MANAGER ITG_Thing_MANAGER {get;set;}

		ITG_transactionLog_MANAGER ITG_transactionLog_MANAGER {get;set;}

		ITG_tuihuo_MANAGER ITG_tuihuo_MANAGER {get;set;}

		ITG_TXmoney_MANAGER ITG_TXmoney_MANAGER {get;set;}

		ITG_wuliu_MANAGER ITG_wuliu_MANAGER {get;set;}

		ITokenConfig_MANAGER ITokenConfig_MANAGER {get;set;}

		IYX_Event_MANAGER IYX_Event_MANAGER {get;set;}

		IYX_image_MANAGER IYX_image_MANAGER {get;set;}

		IYX_music_MANAGER IYX_music_MANAGER {get;set;}

		IYX_news_MANAGER IYX_news_MANAGER {get;set;}

		IYX_sysConfigs_MANAGER IYX_sysConfigs_MANAGER {get;set;}

		IYX_sysLog_MANAGER IYX_sysLog_MANAGER {get;set;}

		IYX_sysNews_MANAGER IYX_sysNews_MANAGER {get;set;}

		IYX_text_MANAGER IYX_text_MANAGER {get;set;}

		IYX_video_MANAGER IYX_video_MANAGER {get;set;}

		IYX_voice_MANAGER IYX_voice_MANAGER {get;set;}

		IYX_weiUser_MANAGER IYX_weiUser_MANAGER {get;set;}

		IYX_weiXinMenus_MANAGER IYX_weiXinMenus_MANAGER {get;set;}

   }
}