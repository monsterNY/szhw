import axios from 'axios';
import ReactDOM from 'react-dom';
// 载入默认全局样式 normalize 、.clearfix 和一些 mixin 方法等
import '@icedesign/base/reset.scss';
import router from './router';
import {
  Feedback,
} from '@icedesign/base';

const ICE_CONTAINER = document.getElementById('ice-container');

global.CusStyle = {
  hideStyle: {
    display: 'none',
  },
};

// 全局注册 Api 配置信息
global.APIConfig = {
  userInfo: { // 用户信息【unUseFul】
    id: 2018,
  },
  // 无需授权功能api入口
  baseUrl: 'http://api.moreover.manage/api/home',
  // 需授权验证功能api入口
  baseAuthUrl: 'http://api.moreover.manage/api/auth',
  // 图片资源
  imgBaseUrl: 'http://api.moreover.manage/',
  // 单图片上传入口
  uploadUrl: 'http://api.moreover.manage/api/util/UploadSingleImage',
  // base64上传入口
  uploadBase64Url: 'http://api.moreover.manage/api/util/UploadBase64Image',
  // 默认图
  defaultImgUrl: 'https://ss0.bdstatic.com/70cFuHSh_Q1YnxGkpoWK1HF6hhy/it/u=228096746,165288188&fm=27&gp=0.jpg',
  // 缓存标识符
  userInfoCacheKey: '_vlxm_user_cache_info_',
  // 获取图片资源地址
  getImgSrc: (src) => {
    return src ? (global.APIConfig.imgBaseUrl + src) : global.APIConfig.defaultImgUrl;
  },
  // 获取本地用户缓存
  getUserCache: () => {
    const value = window.localStorage[global.APIConfig.userInfoCacheKey];
    if (value) {
      const userCacheInfo = JSON.parse(window.localStorage[global.APIConfig.userInfoCacheKey]);
      return userCacheInfo;
    }
  },
  // 更新本地用户缓存
  setUserCache: (userInfo) => {
    if (userInfo) {
      window.localStorage[global.APIConfig.userInfoCacheKey] = JSON.stringify(userInfo);
    } else {
      window.localStorage[global.APIConfig.userInfoCacheKey] = null;
    }
  },
  // 结果码映射
  resultCodeMap: {
    success: 0,
  },
  // 操作标识符
  optMethod: {
    GetArticlePageList: 'GetArticlePageList',
    GetArticleTypePageList: 'GetArticleTypePageList',
    GetArticleTagPageList: 'GetArticleTagPageList',
    GetArticleDetail: 'GetArticleDetail',
    CreateUserInfo: 'CreateUserInfo',
    UserLogin: 'UserLogin',
    AddArticlePv: 'AddArticlePv',
    GetArticleCommentPageList: 'GetArticleCommentPageList',
    GetReplyCommentPageList: 'GetReplyCommentPageList',
    GetArticleSingle: 'GetArticleSingle',
  },
  // 操作标识符
  optAuthMethod: {
    GetUserDetail: 'GetUserDetail',
    UpdateUserInfo: 'UpdateUserInfo',
    SelectAction: 'SelectAction',
    SingleAction: 'SingleAction',
    InsertArticle: 'InsertArticle',
    InsertArticleComment: 'InsertArticleComment',
    GetArticlePageList: 'GetArticlePageList',
    RemoveArticle: 'RemoveArticle',
    SearchIsExistsAttention: 'SearchIsExistsAttention',
    AttentionUser: 'AttentionUser',
    CancelAttentionUser: 'CancelAttentionUser',
    GetAttentionPageList: 'GetAttentionPageList',
    EditArticleInfo: 'EditArticleInfo',
  },
  ValidFlagArr: [
    '无效',
    '有效',
  ],
  // 参数签名[no sign]
  getSignFunc: (paramObj) => {
    return `no sign ${paramObj}`;
  },
  // 发送ajax请求
  baseSendAjax: (url, paramObj, callBack, errorFunc, authErrorFunc, responseErrorFunc, token) => {
    axios
      .post(url, paramObj, {
        headers: {
          Authorization: token,
        },
      })
      .then((response) => {
        console.log(response.data);
        if (response.data.errorCode === global.APIConfig.resultCodeMap.success) {
          callBack(response.data.result);
        } else if (response.data.errorCode === 401 && authErrorFunc) {
          console.log('auth error');
          authErrorFunc();
        } else if (errorFunc) {
          console.log('deal error');
          errorFunc(response.data.message); // 异常回调
        }
      })
      .catch((error) => {
        console.log(error);
        if (responseErrorFunc) {
          responseErrorFunc(error); // 异常回调
        }
      });
  },
  // 发送ajax[无授权]
  sendAjax: (paramObj, optFlag, callBack, errorFunc) => {
    paramObj = global.APIConfig.getParamFunc(optFlag, paramObj);

    console.log(paramObj);

    global.APIConfig.baseSendAjax(global.APIConfig.baseUrl, paramObj, callBack, errorFunc);
  },
  // 发送ajax[带授权]
  sendAuthAjax: (localInstance, paramObj, optFlag, callBack, errorFunc, backUrl) => {
    paramObj = global.APIConfig.getParamFunc(optFlag, paramObj);

    console.log(paramObj);

    const userCacheInfo = global.APIConfig.getUserCache();

    if (!userCacheInfo) {
      Feedback.toast.error('尚未登录！');
      if (backUrl) {
        localInstance.props.history.push(backUrl);
      } else {
        localInstance.props.history.push('/user/login');
      }
      return;
    }

    console.log(userCacheInfo);

    const token = `${userCacheInfo.token_type} ${userCacheInfo.access_token}`;

    console.log(token);

    global.APIConfig.baseSendAjax(global.APIConfig.baseAuthUrl, paramObj, callBack, errorFunc, () => {
      Feedback.toast.error('登录信息已失效！');
      global.APIConfig.setUserCache();
      if (backUrl) {
        localInstance.props.history.push(backUrl);
      } else {
        localInstance.props.history.push('/user/login');
      }
    }, (error) => {
      console.log(error);
      // if (error.response.status === 401) {
      //   Feedback.toast.error('登录信息已失效！');
      //   global.APIConfig.setUserCache();
      //   if (backUrl) {
      //     localInstance.props.history.push(backUrl);
      //   } else {
      //     localInstance.props.history.push('/user/login');
      //   }
      // }
    }, token);
  },
  // 获取统一参数
  getParamFunc: (optFlag, paramObj) => {
    return {
      version: 1.0,
      operationFlag: optFlag,
      param: paramObj,
      sign: global.APIConfig.getSignFunc(paramObj),
    };
  },
  testFunc: () => {
    console.log('testFunc');
  },
};

if (!ICE_CONTAINER) {
  throw new Error('当前页面不存在 <div id="ice-container"></div> 节点.');
}

ReactDOM.render(router, ICE_CONTAINER);
