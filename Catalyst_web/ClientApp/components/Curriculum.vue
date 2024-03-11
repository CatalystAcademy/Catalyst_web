<template>
  <section class="course-one course-page">
    <div class="container">
      <div class="row" v-if="curriculums.length">
        <div class="col-lg-4" v-for="curriculum in curriculums" :key="curriculum.id">
          <div class="course-one__single">
            <div class="course-one__image">
              <img :src="'/assets/images/custom/' + getFirstName(curriculum.titleEng) + '.png'" alt="">
              <i class="far fa-heart"></i><!-- /.far fa-heart -->
            </div><!-- /.course-one__image -->
            <div class="course-one__content">
              <span class="course-one__category">{{curriculum.categoryEng}}</span><!-- /.course-one__category -->
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
                <span class="course-one__count">{{curriculum.rating}}</span><!-- /.course-one__count -->
                <span class="course-one__stars-count">{{curriculum.studentsCountOnCurriculum}}</span><!-- /.course-one__stars-count -->
              </div><!-- /.course-one__stars -->
              <div class="course-one__meta">
                <i class="far fa-clock"></i> {{curriculum.duration}} {{translations.Months}}
                <i class="far fa-folder-open"></i> {{curriculum.lectures}} {{translations.Lectures}}
              </div><!-- /.course-one__meta -->
              <nuxt-link :to="`curriculums/${curriculum.id}`" class="course-one__link">
                {{translations.SeePreview}}
              </nuxt-link>
            </div><!-- /.course-one__content -->
          </div><!-- /.course-one__single -->
        </div><!-- /.col-lg-4 -->

      </div><!-- /.row -->

    </div><!-- /.container -->

  </section>
</template>


<script>
  import https from 'https';
  import { mapState } from 'vuex';

  export default {
    name: 'Curriculum',
    data() {
      return {
        curriculums: [],
        error: false,
      };
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
        console.log(this.curriculums);

      } catch (error) {
        console.error('Error fetching curriculums:', error);
        this.error = true;
      }
    },
    methods: {
      getFirstName(fullName) {
        if (!fullName) return '';
        return fullName.split(' ')[0].toLowerCase();
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
