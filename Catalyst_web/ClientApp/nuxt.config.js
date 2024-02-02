export default {
  layout: 'default',
  axios: {
    baseURL: 'https://localhost:7226',
  },

  // Global page headers: https://go.nuxtjs.dev/config-head
  head: {
    title: 'ClientApp',
    htmlAttrs: {
      lang: 'en'
    },
    meta: [
      { charset: 'utf-8' },
      { name: 'viewport', content: 'width=device-width, initial-scale=1' },
      { hid: 'description', name: 'description', content: '' },
      { name: 'format-detection', content: 'telephone=no' }
    ],
    link: [
      { rel: 'icon', type: 'image/x-icon', href: '/favicon.ico' },
      { rel: 'icon', type: 'image/png', sizes: '32x32', href: '/assets/images/favicons/favicon-32x32.png' },
      { rel: 'icon', type: 'image/png', sizes: '16x16', href: '/assets/images/favicons/favicon-16x16.png' },

      { rel: "stylesheet", href: "https://fonts.googleapis.com/css?family=Poppins:300,400,500,500i,600,700,800%7CSatisfy&display=swap" },

      { rel: "stylesheet", href: "/assets/css/animate.min.css" },
      { rel: "stylesheet", href: "/assets/css/bootstrap.min.css" },
      { rel: "stylesheet", href: "/assets/css/owl.carousel.min.css" },
      { rel: "stylesheet", href: "/assets/css/owl.theme.default.min.css" },
      { rel: "stylesheet", href: "/assets/plugins/fontawesome-free-5.11.2-web/css/all.min.css" },
      { rel: "stylesheet", href: "/assets/plugins/kipso-icons/style.css" },
      { rel: "stylesheet", href: "/assets/css/magnific-popup.css" },
      { rel: "stylesheet", href: "/assets/css/vegas.min.css" },
      { rel: "stylesheet", href: "/assets/css/style.css" },
      { rel: "stylesheet", href: "/assets/css/responsive.css" }
    ],
    script: [
      { src: "/assets/js/jquery.min.js", body: true },
      { src: "/assets/js/bootstrap.bundle.min.js", body: true },
      { src: "/assets/js/waypoints.min.js", body: true },
      { src: "/assets/js/owl.carousel.min.js", body: true },
      { src: "/assets/js/jquery.counterup.min.js", body: true },
      { src: "/assets/js/TweenMax.min.js", body: true },
      { src: "/assets/js/wow.js", body: true },
      { src: "/assets/js/jquery.magnific-popup.min.js", body: true },
      { src: "/assets/js/countdown.min.js", body: true },
      { src: "/assets/js/vegas.min.js", body: true },
      { src: "/assets/js/jquery.validate.min.js", body: true },
      { src: "/assets/js/jquery.ajaxchimp.min.js", body: true },
    ]
  },
  router: {
    routes: [
      {
        path: '/',
        component: 'Home'
      },
      {
        path: '/about',
        component: 'about'
      },
      {
        path: '/missionandvision',
        component: 'missionandvision'
      },
      {
        path: '/courses',
        component: 'courses'
      },
      {
        path: '/contact',
        component: 'contact'
      },
      {
        path: '/faq',
        component: 'faq'
      },
      {
        path: '/curriculums',
        component: 'curriculums'
      },
      {
        path: '/teachers',
        component: 'teachers'
      },
      {
        path: '/blogs',
        component: 'blogs'
      },
      {
        path: '/courses/:id',
        // component: () => import('./pages/courses'),
      },
      {
        path: '/curriculums/:id',
      },
      {
        path: '/teachers/:id',
      },
      {
        path: '/admin/Index',
        component: 'Index'
      },
      {
        path: '/admin/Course/Create',
        component: 'Create'
      },
      {
        path: '/admin/Course/edit/:id',
/*        name: 'EditCourse',
        component: 'Edit'*/
      },
      {
        path: '/news/:id',
      },
      {
        path: '/blogs/:id',
      },
      {
        path: '/admin/Course/List',
        component: 'List'
      },
      {
        path: '/admin/blogs/list',
        component: 'list'
      },

      {
        path: '/admin/blogs/create',
        component: 'create'
      },
      {
        path: '/admin/News/List',
        component: 'List'
      },
      {
        path: '/admin/News/Create',
        component: 'Create'
      }
    ]
  },
  loading: {
    color: '#f16101',
    height: '4px'
  },

  // Global CSS: https://go.nuxtjs.dev/config-css
  css: [
  ],

  // Plugins to run before rendering page: https://go.nuxtjs.dev/config-plugins
  plugins: [
    { src: '~/plugins/vue-toasted.js', mode: 'client' },
    { src: '~/plugins/vue-modal-dialogs.js', mode: 'client' },
    { src: '~/plugins/vue-datepicker', ssr: false },
    { src: '~plugins/bootstrap-vue.js', ssr: false },
    '~/plugins/moment.js',
  ],

  // Auto import components: https://go.nuxtjs.dev/config-components
  components: true,

  // Modules for dev and build (recommended): https://go.nuxtjs.dev/config-modules
  buildModules: [
  ],

  // Modules: https://go.nuxtjs.dev/config-modules
  modules: [
    '@nuxtjs/axios',
    '@nuxtjs/i18n',
    'moment'
  ],
  i18n: {
    locales: ['en-US', 'hy-AM'], // Add more locales as needed
    defaultLocale: 'en-US',
    vueI18n: {
      fallbackLocale: 'en-US',
      messages: {}, // Empty for now, as translations will be fetched dynamically
    },
  },
  store: true,
  // Build Configuration: https://go.nuxtjs.dev/config-build
  build: {
  }
}
