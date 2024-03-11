<template>
  <div>
  <section class="course-one__top-title home-one">
      <div class="container">
          <div class="block-title mb-0">
            <h2 class="block-title__title">{{translations.ExploreOurProgramsText}}</h2><!-- /.block-title__title -->
          </div><!-- /.block-title -->
      </div><!-- /.container -->
      <div class="course-one__top-title__curve"></div><!-- /.course-one__top-title__curve -->
  </section>
  <section class="course-one course-one__teacher-details home-one">
    <div class="container">
        <div class="course-one__carousel owl-carousel owl-theme" v-if="curriculums.length">
            <div class="item" v-for="curriculum in curriculums" :key="curriculum.id">
                <div class="course-one__single color-1">
                  <div class="course-one__image">
                    <img :src="'/assets/images/custom/' + getFirstName(curriculum.titleEng) + '.png'" alt="">
                    <i class="far fa-heart"></i><!-- /.far fa-heart -->
                  </div><!-- /.course-one__image -->
                    <div class="course-one__content">
                      <a href="#" class="course-one__category">{{curriculum.categoryEng}}</a><!-- /.course-one__category -->
                      <div class="course-one__admin">
                        <img src="/assets/images/logo/ca_logo.png" alt="">
                        by <span> {{translations.CatalystAcademyText}}</span>
                      </div><!-- /.course-one__admin -->
                        <h2 class="course-one__title">
                          <nuxt-link :to="`curriculums/${curriculum.id}`">
                            {{ curriculum.titleEng }}
                          </nuxt-link>
                        </h2>
                        <!-- /.course-one__title -->
                        <div class="course-one__stars">
                            <span class="course-one__stars-wrap">
                                <i class="fa fa-star"></i>
                                <i class="fa fa-star"></i>
                                <i class="fa fa-star"></i>
                                <i class="fa fa-star"></i>
                                <i class="fa fa-star"></i>
                            </span><!-- /.course-one__stars-wrap -->
                            <span class="course-one__count">5</span><!-- /.course-one__count -->
                            <span class="course-one__stars-count">580</span><!-- /.course-one__stars-count -->
                        </div><!-- /.course-one__stars -->
                        <div class="course-one__meta">
                          <i class="far fa-clock"></i> 3 {{translations.Months}}
                          <i class="far fa-folder-open"></i> 36 {{translations.Lectures}}
                        </div><!-- /.course-one__meta -->
                        <nuxt-link :to="`curriculums/${curriculum.id}`" class="course-one__link">
                          {{translations.SeePreview}}
                        </nuxt-link>
                      </div><!-- /.course-one__content -->
                </div><!-- /.course-one__single -->
            </div><!-- /.item -->

        </div><!-- /.course-one__carousel -->
    </div><!-- /.container -->
</section>
  </div>

</template>

<script>
  import https from 'https';
  import { mapState } from 'vuex';

  export default {
    name: 'CourseOne',
    data() {
      return {
        curriculums: [],
        error: false,
      };
    },
    methods: {
      getFirstName(fullName) {
        if (!fullName) return '';
        return fullName.split(' ')[0].toLowerCase();
      }
    },
    computed: {
      ...mapState(['language']),
      translations() {
        return this.$store.state.translations;
      },
    },
    async fetch() { // Use fetch for component-level data fetching
      try {
        const response = await this.$axios.get('/api/Curriculums');
        this.curriculums = response.data;

      } catch (error) {
        console.error('Error fetching curriculums:', error);
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
