<template>
  <section class="blog-details">
    <div class="container">
        <div class="row">
            <div class="col-lg-8">
                <div class="blog-one__single">
                    <div class="blog-one__image">
                        <img src="/assets/images/custom/news_770.jpg" alt="">

                    </div><!-- /.blog-one__image -->
                    <div class="blog-one__content text-center">
                        <div class="blog-one__meta">
                            <span data-toggle="tooltip" data-placement="top" title="" v-bind:data-original-title="translations.PostedOn + ': ' + formatDateMonth(news.created)"><i class="fa fa-calendar-alt"></i></span>
<!--                            <a data-toggle="tooltip" data-placement="top" title="" href="#" data-original-title="Posted By Admin"><i class="fa fa-user"></i></a>
-->                        </div><!-- /.blog-one__meta -->
                        <h2 class="blog-one__title">
                          {{news.titleEng}}

                        </h2><!-- /.blog-one__title -->
                        <p class="blog-one__text level-description"><span class="level-text">{{news.descriptionEng}}</span>
                        </p><!-- /.blog-one__text -->
                       
                    </div><!-- /.blog-one__content -->
                </div><!-- /.blog-one__single -->
                <div class="share-block">
                  <div class="left-block" v-if="news.tag && news.tag.length > 0">
                    <p>{{translations.Tags}}: <span>{{ news.tag.split(' ').join(', ') }}</span></p>
                  </div><!-- /.left-block -->
                    <div class="social-block">
                        <a href="#"><i class="fab fa-twitter"></i></a>
                        <a href="#"><i class="fab fa-facebook-f"></i></a>
                        <a href="#"><i class="fab fa-instagram"></i></a>
                        <a href="#"><i class="fab fa-dribbble"></i></a>
                    </div><!-- /.social-block -->
                </div><!-- /.share-block -->
            </div><!-- /.col-lg-8 -->
            <div class="col-lg-4">
                <div class="sidebar">
<!--                    <div class="sidebar__single sidebar__search">
                        <form action="#" class="sidebar__search-form">
                            <input type="text" name="search" placeholder="Search here...">
                            <button type="submit"><i class="fa fa-search"></i></button>
                        </form>
                    </div>--><!-- /.sidebar__single -->
                    <div class="sidebar__single sidebar__post">
                      <h3 class="sidebar__title">{{translations.LatestNews}}</h3><!-- /.sidebar__title -->
                        <div class="sidebar__post-wrap" v-for="singleNews in latestNews" :key="singleNews.id">
                            <div class="sidebar__post__single mt-3">
                                <div class="sidebar__post-image">
                                    <div class="inner-block">
                                  <img src="/assets/images/custom/news_66.jpg" alt="Awesome Image">
                                    </div>
                                    <!-- /.inner-block -->
                                </div><!-- /.sidebar__post-image -->
                                <div class="sidebar__post-content">
                                    <h4 class="sidebar__post-title"><nuxt-link :to="`/news/${singleNews.id}`">{{singleNews.titleEng.slice(0, 20)}}</nuxt-link></h4>
                                    <!-- /.sidebar__post-title -->
                                </div><!-- /.sidebar__post-content -->
                            </div><!-- /.sidebar__post__single -->
                           
                        </div><!-- /.sidebar__post-wrap -->
                    </div><!-- /.sidebar__single -->

                    <div class="sidebar__single sidebar__tags" v-if="news.tag && news.tag.length > 0">
                      <h3 class="sidebar__title">{{translations.Tags}}</h3><!-- /.sidebar__title -->
                      <ul class="sidebar__tags-list">
                        <li class="sidebar__tags-list-item">{{ news.tag.split(' ').join(', ') }}</li>

                      </ul><!-- /.sidebar__category-list -->
                    </div><!-- /.sidebar__single -->
                </div><!-- /.sidebar -->
            </div><!-- /.col-lg-4 -->
        </div><!-- /.row -->
    </div><!-- /.container -->
</section>
</template>

<script>
  export default {
    name: "NewsDetails",
    async fetch() {
      const newsId = this.$route.params.id; // Get news ID from route parameters
      try {
        const response = await this.$axios.get(`/api/NewsDetails/${newsId}`); 
        this.news = response.data;

        const latestN = await this.$axios.get(`/api/News/Latest?currentNewsId=${newsId}`);
        this.latestNews = latestN.data;
      } catch (error) {
        // Handle errors
      }
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    methods: {
      formatDateMonth(date) {
        // Use this.$moment to format the date
        return this.$moment(date).format('MMM D');
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    },
    data() {
      return {
        latestNews: [],
        news: {},
      };
    },
  };
</script>

<style scoped>

</style>
