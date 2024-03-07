<template>
  <section class="course-details">
    <div class="container">
      <div class="row">
        <div class="col-lg-8">
          <div class="course-details__content">
            <p class="course-details__author">
              <img src="/assets/images/team-1-1.jpg" alt="">
              by <a href="#">{{translations.CatalystAcademyText}}</a>
            </p><!-- /.course-details__author -->

            <div class="course-details__top">
              <div class="course-details__top-left">
                <h2 class="course-details__title">{{curriculum.titleEng}}</h2>
                <!-- /.course-details__title -->
                <div class="course-one__stars">
                  <span class="course-one__stars-wrap">
                    <i class="fa fa-star"></i>
                    <i class="fa fa-star"></i>
                    <i class="fa fa-star"></i>
                    <i class="fa fa-star"></i>
                    <i class="fa fa-star"></i>
                  </span><!-- /.course-one__stars-wrap -->
                  <span class="course-one__count">{{curriculum.rating}}</span><!-- /.course-one__count -->
                  <span class="course-one__stars-count">{{curriculum.studetns}}</span><!-- /.course-one__stars-count -->
                </div><!-- /.course-one__stars -->
              </div><!-- /.course-details__top-left -->
              <div class="course-details__top-right">
                <a href="#" class="course-one__category">{{curriculum.categoryEng}}</a><!-- /.course-one__category -->
              </div><!-- /.course-details__top-right -->
            </div><!-- /.course-details__top -->
            <div class="course-one__image">
              <img src="/assets/images/course-d-1.jpg" alt="">
              <i class="far fa-heart"></i><!-- /.far fa-heart -->
            </div><!-- /.course-one__image -->

            <ul class="course-details__tab-navs list-unstyled nav nav-tabs" role="tablist">
              <li>
                <a class="active" role="tab" data-toggle="tab" href="#overview">Overview</a>
              </li>
              <li>
                <a class="" role="tab" data-toggle="tab" href="#curriculum">Curriculum</a>
              </li>
            </ul><!-- /.course-details__tab-navs list-unstyled -->
            <div class="tab-content course-details__tab-content ">
              <div class="tab-pane show active  animated fadeInUp" role="tabpanel" id="overview">
                <p class="course-details__tab-text">
                  {{curriculum.descriptionEng}}
                </p><!-- /.course-details__tab-text -->

              </div><!-- /.course-details__tab-content -->
              <div class="tab-pane  animated fadeInUp" role="tabpanel" id="curriculum">
                <h3 class="course-details__tab-title">{{curriculum.curriculumDescriptionTitleEng}}</h3>
                <br>
                <p class="course-details__tab-text">
                  <div v-for="module in curriculumEng" :key="module.number">
                    <p>{{ module.text }}</p>
                  </div>
                </p>

              </div><!-- /.course-details__tab-content -->
            </div><!-- /.tab-content -->
          </div><!-- /.course-details__content -->
        </div><!-- /.col-lg-8 -->
        <div class="col-lg-4">
          <div class="course-details__price">
            <nuxt-link to="/apply" class="thm-btn course-details__price-btn">{{translations.RegisterNow}}</nuxt-link><!-- /.thm-btn -->
          </div><!-- /.course-details__price -->

          <div class="course-details__meta">
            <a href="#" class="course-details__meta-link">
              <span class="course-details__meta-icon">
                <i class="far fa-clock"></i><!-- /.far fa-clock -->
              </span><!-- /.course-details__icon -->
              {{translations.Durations}}: <span>{{curriculum.duration}} {{translations.Months}}</span>
            </a><!-- /.course-details__meta-link -->
            <a href="#" class="course-details__meta-link">
              <span class="course-details__meta-icon">
                <i class="far fa-folder-open"></i><!-- /.far fa-folder-open -->
              </span><!-- /.course-details__icon -->
              {{translations.Lectures}}: <span>{{curriculum.lectures}}</span>
            </a><!-- /.course-details__meta-link -->
            <a href="#" class="course-details__meta-link">
              <span class="course-details__meta-icon">
                <i class="far fa-user-circle"></i><!-- /.far fa-user-circle -->
              </span><!-- /.course-details__icon -->
              {{translations.Students}}: <span>{{translations.Max}} {{curriculum.students}}</span>
            </a><!-- /.course-details__meta-link -->
            <a href="#" class="course-details__meta-link">
              <span class="course-details__meta-icon">
                <i class="far fa-flag"></i><!-- /.far fa-flag -->
              </span><!-- /.course-details__icon -->
              {{translations.SkillLevel}}: <span>{{curriculum.skillLevel}}</span>
            </a><!-- /.course-details__meta-link -->
            <a href="#" class="course-details__meta-link">
              <span class="course-details__meta-icon">
                <i class="far fa-bell"></i><!-- /.far fa-bell -->
              </span><!-- /.course-details__icon -->
              {{translations.Language}}: <span>{{curriculum.language}}</span>
            </a><!-- /.course-details__meta-link -->
          </div><!-- /.course-details__meta -->
          <div class="course-details__list">
            <h2 class="course-details__list-title">{{translations.OurCurriculums}}</h2><!-- /.course-details__list-title -->
            <div class="course-details__list-item" v-for="singleC in latestCurriculums" :key="singleC.id">
              <div class="course-details__list-img">
                <img src="/assets/images/lc-1-1.jpg" alt="">
              </div><!-- /.course-details__list-img -->
              <div class="course-details__list-content">
                <a class="course-details__list-author" href="#">by <span>{{translations.CatalystAcademyText}}</span></a>
                <h3><nuxt-link :to="`/curriculums/${singleC.id}`">{{singleC.titleEng}}</nuxt-link></h3>
                <div class="course-details__list-stars">
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <span>{{singleC.rating}}</span>
                </div><!-- /.course-details__list-stars -->
              </div><!-- /.course-details__list-content -->
            </div><!-- /.course-details__list-item -->

          </div><!-- /.course-details__list -->
        </div><!-- /.col-lg-4 -->
      </div><!-- /.row -->
    </div><!-- /.container -->
  </section>

</template>

<script>
  import { mapState } from 'vuex';

  export default {
    name: "CurriculumDetails",
    methods: {
      scrollToTarget() {
        const targetElement = document.getElementById('register-section');
        targetElement.scrollIntoView({ behavior: 'smooth', block: 'start' });
      },
      async register() {
        try {
          this.registrationData.curriculumId = this.curriculumId;

          // Send registration data without FormData
          await this.$axios.post('/api/Curriculums/Register', this.registrationData)
            .then(response => {
              // Show success or error toast based on response
              if (response.status === 200) {
                this.$toasted.success('Registration successful!');
                setTimeout(() => {
                  window.location = `/curriculums/${this.curriculumId}`; // Redirect after a delay
                }, 3000);
              } else {
                this.$toasted.error('An unexpected error occurred. Please contact support.'); // Assuming a 'message' property in error response
              }
            })
            .catch(error => {
              // Handle generic errors
              this.$toasted.error('An error occurred during registration. Please try again.');
              console.log(parsedDate);
            });
        } catch (error) {
        }
      },
    },
    computed: {
      ...mapState(['language']),
      translations() {
        return this.$store.state.translations;
      },
    },
    async fetch() {
      try {
        const response = await this.$axios.get(`/api/CurriculumDetails/${this.curriculumId}`); // Fetch data based on ID
        this.curriculum = response.data;
        const rawData = response.data.curriculumEng;
        this.curriculumEng = rawData
          .split('\n') // Split on newlines (assuming each point is on a separate line)
          .map((point, index) => ({ number: `${index + 1}.`, text: point })); // Add numbering and spaces

        const latestCurriculum = await this.$axios.get(`/api/Curriculums/Latest?currentCurriculumId=${this.curriculumId}`);
        this.latestCurriculums = latestCurriculum.data;

      } catch (error) {
        // Handle errors
      }
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    },
    data() {
      return {
        value: '',
        showDecadeNav: true,
        hideHeader: true,
        DateOfBirth: null,
        curriculum: {},
        curriculumId: this.$route.params.id,
        curriculumEng: '',
        latestCurriculums: [],
        registrationData: { fullName: '', email: '', curriculumId: null, phoneNumber: '', DateOfBirth: '', parentPhoneNumber: '', address: '', educationalInstitution: '', parentEmail: '', parentFullName: '', parentProfession: '', message: '' },
      };
    },
  };
</script>

<style scoped>
  .become-teacher__form {
    padding-left: 0px !important;
    margin-top: 15px !important;
    position: relative;
  }
  .form-control {
    background-color: #f1f1f1 !important;
    height: auto !important;
  }
  .b-calendar-grid-body .no-gutters .col {
    max-width: 14% !important;
  }
  .col {
    flex-basis: 0;
    flex-grow: 1;
    max-width: 14% !important;
  }
  .no-gutters > .col, .no-gutters > [class*=col-] {
    padding-right: 0;
    padding-left: 0;
    max-width: 14% !important;
  }
</style>
