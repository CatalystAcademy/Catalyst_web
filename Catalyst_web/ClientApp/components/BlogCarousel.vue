<template>
  <section class="blog-two">
      <div class="container" v-if="blogs.length">
          <div class="block-title text-center">
              <h2 class="block-title__title">Our latest news <br>
                  & articles</h2><!-- /.block-title__title -->
          </div><!-- /.block-title -->
          <div class="blog-two__carousel owl-carousel owl-theme">
              <div class="item" v-for="blog in blogs" :key="blog.id">
                  <div class="blog-two__single" :style="{backgroundImage: `url(assets/images/custom/leader.png)`}">
                      <div class="blog-two__inner">
                        <a href="/news-details" class="blog-two__date">
                          <span>{{formatDateOnlyDay(blog.Created)}}</span>
                          {{formatDateMonth(blog.Created)}}
                        </a><!-- /.blog-two__date -->
                          <div class="blog-two__meta">
                              <a href="#">by {{blog.authorEng}}</a>
<!--                              <a href="#">3 Comments</a>
-->                          </div><!-- /.blog-two__meta -->
                          <h3 class="blog-two__title">
                            <nuxt-link :to="`blogs/${blog.id}`">{{blog.titleEng.slice(0, 30)}}</nuxt-link>
                          </h3><!-- /.blog-two__title -->
                      </div><!-- /.blog-two__inner -->
                  </div><!-- /.blog-two__single -->
              </div><!-- /.item -->
          </div><!-- /.blog-two__carousel owl-carousel owl-theme -->
      </div><!-- /.container -->
  </section>
</template>

<script>
  import https from 'https';

    export default {
    name: "BlogCarousel",
    data() {
      return {
        blogs: [],
        error: false,
      };
    },
    methods: {
      formatDateOnlyDay(date) {
        // Use this.$moment to format the date
        return this.$moment(date).format('D');
      },
      formatDateMonth(date) {
        // Use this.$moment to format the date
        return this.$moment(date).format('MMM');
      },
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
