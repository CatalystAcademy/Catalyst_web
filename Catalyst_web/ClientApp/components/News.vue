<template>
  <section class="blog-one blog-page">
      <div class="container">
          <div class="row" v-if="news.length">
              <div class="col-lg-4" v-for="n in news" :key="n.id">
                  <div class="blog-one__single">
                      <div class="blog-one__image">
                          <img src="/assets/images/custom/news_370.jpg" alt="">
                          <nuxt-link class="blog-one__plus" :to="`news/${n.id}`"><i class="kipso-icon-plus-symbol"></i>
                              <!-- /.kipso-icon-plus-symbol --></nuxt-link>
                      </div><!-- /.blog-one__image -->
                      <div class="blog-one__content text-center">
                          <div class="blog-one__meta">
                              <span data-toggle="tooltip" data-placement="top" title="" v-bind:data-original-title="translations.PostedOn + ': ' + formatDateMonth(n.created)"><i class="fa fa-calendar-alt"></i></span>
<!--                              <a data-toggle="tooltip" data-placement="top" title="" href="#" v-bind:data-original-title="translations.PostedBy + ': ' + n.authorEng"><i class="fa fa-user"></i></a>
-->                          </div><!-- /.blog-one__meta -->
                          <h2 class="blog-one__title"><nuxt-link :to="`news/${n.id}`">{{n.titleEng.slice(0, 30)}}</nuxt-link>
                          </h2><!-- /.blog-one__title -->
                          <p class="blog-one__text">{{n.descriptionEng.slice(0, 80)}}</p><!-- /.blog-one__text -->
                          <nuxt-link :to="`news/${n.id}`" class="blog-one__link">{{translations.ReadMore}}</nuxt-link><!-- /.blog-one__link -->
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
    name: 'News',
    data() {
      return {
        news: [],
        error: false,
      };
    },
    methods: {
      formatDateMonth(date) {
        // Use this.$moment to format the date
        return this.$moment(date).format('MMM D');
      },
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
