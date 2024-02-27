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
                  <span class="course-one__count">5</span><!-- /.course-one__count -->
                  <span class="course-one__stars-count">580</span><!-- /.course-one__stars-count -->
                </div><!-- /.course-one__stars -->
              </div><!-- /.course-details__top-left -->
              <div class="course-details__top-right">
                <a href="#" class="course-one__category">marketing</a><!-- /.course-one__category -->
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
                  Aelltes port lacus quis enim var sed efficitur turpis
                  gilla
                  sed sit Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                  Ipsum has been the industry’s standard dummy text ever since the 1500s, when an unknown
                  printer took a galley of type and scrambled it to make a type specimen book. It has
                  survived
                  not only five centuries, but also the leap into electronic typesetting, remaining
                  essentially unchanged.
                </p><!-- /.course-details__tab-text -->
                <br>
                <p class="course-details__tab-text">
                  It was popularised in the 1960s with the release of
                  Letraset
                  sheets containing Lorem Ipsum passages, and more recently with desktop publishing
                  software
                  like Aldus PageMaker including versions of lorem ipsum amet finibus eros. Lorem Ipsum is
                  simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the
                  industry’s standard dummy text ever since the 1500s, when an unknown printer took a
                  galley
                  of type and scrambled it to make a type specimen book. It has survived not only five
                  centuries, but also the leap into electronic typesetting.
                </p>
                <!-- /.course-details__tab-text -->
                <br>
                <ul class="list-unstyled course-details__overview-list">
                  <li>It has survived not only five centuries</li>
                  <li>Lorem Ipsum is simply dummy text of the new design</li>
                  <li>Printng and type setting ipsum</li>
                  <li>Take a look at our round up of the best shows</li>
                </ul><!-- /.list-unstyled course-details__overview-list -->
              </div><!-- /.course-details__tab-content -->
              <div class="tab-pane  animated fadeInUp" role="tabpanel" id="curriculum">
                <h3 class="course-details__tab-title">Starting beginners level course</h3>
                <!-- /.course-details__title -->
                <br>
                <p class="course-details__tab-text">
                  Aelltes port lacus quis enim var sed efficitur turpis
                  gilla
                  sed sit Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                  Ipsum has been the industry’s standard dummy text ever since.
                </p>
                <!-- /.course-details__tab-text -->
                <br>
                <ul class="course-details__curriculum-list list-unstyled">
                  <li>
                    <div class="course-details__curriculum-list-left">
                      <div class="course-details__meta-icon video-icon">
                        <i class="fas fa-play"></i><!-- /.fas fa-play -->
                      </div><!-- /.course-details__icon -->
                      <a href="#">Introduction to Editing</a> <span>Preview</span>
                    </div><!-- /.course-details__curriculum-list-left -->
                    <div class="course-details__curriculum-list-right">16 minutes</div>
                    <!-- /.course-details__curriculum-list-right -->
                  </li>
                  <li>
                    <div class="course-details__curriculum-list-left">
                      <div class="course-details__meta-icon video-icon">
                        <i class="fas fa-play"></i><!-- /.fas fa-play -->
                      </div><!-- /.course-details__icon -->
                      <a href="#">Overview of Editing</a> <span>Preview</span>
                    </div><!-- /.course-details__curriculum-list-left -->
                    <div class="course-details__curriculum-list-right">10 minutes</div>
                    <!-- /.course-details__curriculum-list-right -->
                  </li>
                  <li>
                    <div class="course-details__curriculum-list-left">
                      <div class="course-details__meta-icon file-icon">
                        <i class="fas fa-folder"></i><!-- /.far fa-folder -->
                      </div><!-- /.course-details__icon -->
                      <a href="#">Basic Editing Technology</a>
                    </div><!-- /.course-details__curriculum-list-left -->
                    <!-- /.course-details__curriculum-list-right -->
                  </li>
                  <li>
                    <div class="course-details__curriculum-list-left">
                      <div class="course-details__meta-icon quiz-icon">
                        <i class="fas fa-comment"></i><!-- /.fas fa-play -->
                      </div><!-- /.course-details__icon -->
                      <a href="#">Quiz</a>
                    </div><!-- /.course-details__curriculum-list-left -->
                    <div class="course-details__curriculum-list-right">6 questions</div>
                    <!-- /.course-details__curriculum-list-right -->
                  </li>
                </ul><!-- /.course-details__curriculum-list -->
                <br><br>
                <h3 class="course-details__tab-title">Intermediate Level</h3>
                <!-- /.course-details__title -->
                <br>
                <p class="course-details__tab-text">
                  Aelltes port lacus quis enim var sed efficitur turpis
                  gilla
                  sed sit Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem
                  Ipsum has been the industry’s standard dummy text ever since.
                </p>
                <!-- /.course-details__tab-text -->
                <br>
                <ul class="course-details__curriculum-list list-unstyled">
                  <li>
                    <div class="course-details__curriculum-list-left">
                      <div class="course-details__meta-icon video-icon">
                        <i class="fas fa-play"></i><!-- /.fas fa-play -->
                      </div><!-- /.course-details__icon -->
                      <a href="#">Introduction to Editing</a> <span>Preview</span>
                    </div><!-- /.course-details__curriculum-list-left -->
                    <div class="course-details__curriculum-list-right">16 minutes</div>
                    <!-- /.course-details__curriculum-list-right -->
                  </li>
                  <li>
                    <div class="course-details__curriculum-list-left">
                      <div class="course-details__meta-icon file-icon">
                        <i class="fas fa-folder"></i><!-- /.far fa-folder -->
                      </div><!-- /.course-details__icon -->
                      <a href="#">Basic Editing Technology</a>
                    </div><!-- /.course-details__curriculum-list-left -->
                    <!-- /.course-details__curriculum-list-right -->
                  </li>
                  <li>
                    <div class="course-details__curriculum-list-left">
                      <div class="course-details__meta-icon quiz-icon">
                        <i class="fas fa-comment"></i><!-- /.fas fa-play -->
                      </div><!-- /.course-details__icon -->
                      <a href="#">Quiz</a>
                    </div><!-- /.course-details__curriculum-list-left -->
                    <div class="course-details__curriculum-list-right">6 questions</div>
                    <!-- /.course-details__curriculum-list-right -->
                  </li>
                </ul><!-- /.course-details__curriculum-list -->
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
              {{translations.Durations}}: <span>3 {{translations.Months}}</span>
            </a><!-- /.course-details__meta-link -->
            <a href="#" class="course-details__meta-link">
              <span class="course-details__meta-icon">
                <i class="far fa-folder-open"></i><!-- /.far fa-folder-open -->
              </span><!-- /.course-details__icon -->
              {{translations.Lectures}}: <span>36 {{translations.Lectures}}</span>
            </a><!-- /.course-details__meta-link -->
            <a href="#" class="course-details__meta-link">
              <span class="course-details__meta-icon">
                <i class="far fa-user-circle"></i><!-- /.far fa-user-circle -->
              </span><!-- /.course-details__icon -->
              {{translations.Students}}: <span>{{translations.Max}} 15</span>
            </a><!-- /.course-details__meta-link -->
            <a href="#" class="course-details__meta-link">
              <span class="course-details__meta-icon">
                <i class="far fa-flag"></i><!-- /.far fa-flag -->
              </span><!-- /.course-details__icon -->
              {{translations.SkillLevel}}: <span>{{translations.Beginner}}</span>
            </a><!-- /.course-details__meta-link -->
            <a href="#" class="course-details__meta-link">
              <span class="course-details__meta-icon">
                <i class="far fa-bell"></i><!-- /.far fa-bell -->
              </span><!-- /.course-details__icon -->
              {{translations.Language}}: <span>{{translations.Armenian}}</span>
            </a><!-- /.course-details__meta-link -->
          </div><!-- /.course-details__meta -->
          <div class="course-details__list">
            <h2 class="course-details__list-title">{{translations.OurCurriculums}}</h2><!-- /.course-details__list-title -->
            <div class="course-details__list-item">
              <div class="course-details__list-img">
                <img src="/assets/images/lc-1-1.jpg" alt="">
              </div><!-- /.course-details__list-img -->
              <div class="course-details__list-content">
                <a class="course-details__list-author" href="#">by <span>{{translations.CatalystAcademyText}}</span></a>
                <h3><a href="#">Marketing strategies</a></h3>
                <div class="course-details__list-stars">
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <span>4.8</span>
                </div><!-- /.course-details__list-stars -->
              </div><!-- /.course-details__list-content -->
            </div><!-- /.course-details__list-item -->
            <div class="course-details__list-item">
              <div class="course-details__list-img">
                <img src="/assets/images/lc-1-2.jpg" alt="">
              </div><!-- /.course-details__list-img -->
              <div class="course-details__list-content">
                <a class="course-details__list-author" href="#">by <span>Lydia Byrd</span></a>
                <h3><a href="#">Marketing strategies</a></h3>
                <div class="course-details__list-stars">
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <span>4.8</span>
                </div><!-- /.course-details__list-stars -->
              </div><!-- /.course-details__list-content -->
            </div><!-- /.course-details__list-item -->
            <div class="course-details__list-item">
              <div class="course-details__list-img">
                <img src="/assets/images/lc-1-3.jpg" alt="">
              </div><!-- /.course-details__list-img -->
              <div class="course-details__list-content">
                <a class="course-details__list-author" href="#">by <span>Lydia Byrd</span></a>
                <h3><a href="#">Marketing strategies</a></h3>
                <div class="course-details__list-stars">
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <i class="fas fa-star"></i><!-- /.fas fa-star -->
                  <span>4.8</span>
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
  import moment from 'moment';
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
