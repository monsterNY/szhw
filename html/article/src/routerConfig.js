// 以下文件格式为描述路由的协议格式
// 你可以调整 routerConfig 里的内容
// 变量名 routerConfig 为 iceworks 检测关键字，请不要修改名称

import Dashboard from './pages/Dashboard';
import PostList from './pages/PostList';
import NewPost from './pages/NewPost';
import HotPost from './pages/HotPost';
import Status from './pages/Status';
import Settings from './pages/Settings';
import UserLogin from './pages/UserLogin';
import Article from './pages/Article';
import BasicLayout from './layouts/BasicLayout';

import UserArticleList from './pages/UserArticleList';
import ArticleCollect from './pages/ArticleCollect';
import UserRegister from './pages/UserRegister';
import UserAttention from './pages/UserAttention';

const routerConfig = [
  {
    path: '/user/login',
    component: UserLogin,
  },
  {
    path: '/user/register',
    component: UserRegister,
  },
  {
    path: '/dashboard',
    component: Dashboard,
  },
  {
    path: '/post/list',
    component: PostList,
  },
  {
    path: '/post/new',
    component: NewPost,
  },
  {
    path: '/post/analysis',
    component: HotPost,
  },
  {
    path: '/account/my',
    component: Status,
  },
  {
    path: '/account/settings',
    component: Settings,
  },
  {
    path: '/article/detail/:id',
    layout: BasicLayout,
    component: Article,
  },
  {
    path: '/article/edit/:id',
    component: NewPost,
  },
  {
    path: '/article/userList',
    layout: BasicLayout,
    component: UserArticleList,
  },
  {
    path: '/collect/article',
    layout: BasicLayout,
    component: ArticleCollect,
  },
  {
    path: '/collect/attention',
    layout: BasicLayout,
    component: UserAttention,
  },
];

export default routerConfig;
