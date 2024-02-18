<template>
  <section class="blog-one blog-page">
      <div class="container">
          <div class="row" v-if="news.length">
              <div class="col-lg-4" v-for="n in news" :key="n.id">
                  <div class="blog-one__single">
                      <div class="blog-one__image">
                          <img src="/assets/images/blog-1-1.jpg" alt="">
                          <nuxt-link class="blog-one__plus" :to="`news/${n.id}`"><i class="kipso-icon-plus-symbol"></i>
                              <!-- /.kipso-icon-plus-symbol --></nuxt-link>
                      </div><!-- /.blog-one__image -->
                      <div class="blog-one__content text-center">
                          <div class="blog-one__meta">
                              <a data-toggle="tooltip" data-placement="top" title="" href="#" data-original-title="Posted On Jan 19"><i class="fa fa-calendar-alt"></i></a>
                              <a data-toggle="tooltip" data-placement="top" title="" href="#" data-original-title="No Comments"><i class="fa fa-comments"></i></a>
                              <a data-toggle="tooltip" data-placement="top" title="" href="#" data-original-title="Posted By Admin"><i class="fa fa-user"></i></a>
                          </div><!-- /.blog-one__meta -->
                          <h2 class="blog-one__title"><nuxt-link :to="`news/${n.id}`">{{n.titleEng}}</nuxt-link>
                          </h2><!-- /.blog-one__title -->
                          <p class="blog-one__text">Aelltes port lacus quis enim var sed efficitur turpis gilla sed sit
                              amet finibus eros.</p><!-- /.blog-one__text -->
                          <nuxt-link :to="`news/${n.id}`" class="blog-one__link">Read More</nuxt-link><!-- /.blog-one__link -->
                      </div><!-- /.blog-one__content -->
                  </div><!-- /.blog-one__single -->
              </div><!-- /.col-lg-4 -->

          </div><!-- /.row -->
          <div class="post-pagination">
              <a href="#"><i class="fa fa-angle-double-left"></i><!-- /.fa fa-angle-double-left --></a>
              <a class="active" href="#">1</a>
              <a href="#">2</a>
              <a href="#">3</a>
              <a href="#">4</a>
              <a href="#"><i class="fa fa-angle-double-right"></i><!-- /.fa fa-angle-double-left --></a>
          </div><!-- /.post-pagination -->
      </div><!-- /.container -->
  </section>
</template>

<script>
  import https from 'https';

  export default {
    name: 'News',
    data() {
      return {
        news: [],
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
        const response = await this.$axios.get('/api/News');
        this.news = response.data;

      } catch (error) {
        console.error('Error fetching news or welcome message:', error);
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
  };
</script>

<style scoped>

</style>
