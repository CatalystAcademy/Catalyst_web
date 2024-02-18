<template>
  <section class="blog-one  blog-one__home-two">
      <div class="container">
          <div class="block-title text-center">
              <h2 class="block-title__title">Our latest news <br>
                  & articles</h2><!-- /.block-title__title -->
          </div><!-- /.block-title -->
          <div class="row" v-if="blogs.length">
              <div class="col-lg-4" v-for="blog in blogs" :key="blog.id">
                  <div class="blog-one__single">
                      <div class="blog-one__image">
                          <img src="/assets/images/blog-1-1.jpg" alt="">
                          <nuxt-link class="blog-one__plus" :to="`blogs/${blog.id}`"><i class="kipso-icon-plus-symbol"></i>
                              <!-- /.kipso-icon-plus-symbol --></nuxt-link>
                      </div><!-- /.blog-one__image -->
                      <div class="blog-one__content text-center">
                          <div class="blog-one__meta">
                              <a data-toggle="tooltip" data-placement="top" title="Posted On Jan 19" href="#"><i class="fa fa-calendar-alt"></i></a>
                              <a data-toggle="tooltip" data-placement="top" title="No Comments" href="#"><i class="fa fa-comments"></i></a>
                              <a data-toggle="tooltip" data-placement="top" title="Posted By Admin" href="#"><i class="fa fa-user"></i></a>
                          </div><!-- /.blog-one__meta -->
                          <h2 class="blog-one__title"><nuxt-link :to="`blogs/${blog.id}`">{{blog.titleEng}}</nuxt-link>
                          </h2><!-- /.blog-one__title -->
                          <p class="blog-one__text">Aelltes port lacus quis enim var sed efficitur turpis gilla sed sit
                              amet finibus eros.</p><!-- /.blog-one__text -->
                          <nuxt-link :to="`blogs/${blog.id}`" class="blog-one__link">Read More</nuxt-link><!-- /.blog-one__link -->
                      </div><!-- /.blog-one__content -->
                  </div><!-- /.blog-one__single -->
              </div><!-- /.col-lg-4 -->
          </div><!-- /.row -->

      </div><!-- /.container -->
  </section>
</template>

<script>
  import https from 'https';
    export default {
    name: "BlogHome",
    data() {
      return {
        blogs: [],
        error: false,
      };
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    async fetch() { // Use fetch for component-level data fetching
      try {
        const response = await this.$axios.get('/api/blogs');
        this.blogs = response.data;

      } catch (error) {
        console.error('Error fetching blogs or welcome message:', error);
        this.error = true;
      }
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
    }
</script>

<style scoped>

</style>
