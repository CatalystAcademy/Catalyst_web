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
        component: 'About'
      },
      {
        path: '/courses',
        component: 'Courses'
      },
      {
        path: '/course-details/:id',
        component: 'Course-details'
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
  ],

  // Auto import components: https://go.nuxtjs.dev/config-components
  components: true,

  // Modules for dev and build (recommended): https://go.nuxtjs.dev/config-modules
  buildModules: [
  ],

  // Modules: https://go.nuxtjs.dev/config-modules
  modules: [
    '@nuxtjs/axios'
  ],

  // Build Configuration: https://go.nuxtjs.dev/config-build
  build: {
  }
}
