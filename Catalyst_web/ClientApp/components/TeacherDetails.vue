<template>
    <div>
      <section class="team-details">
          <div class="container">
              <div class="row justify-content-between">
                  <div class="col-lg-5">
                      <div class="team-details__content">
                          <h2 class="team-details__title">Read my story</h2><!-- /.team-details__title -->
                          <p class="team-details__text">{{teacher.descriptionEng}}</p><!-- /.team-details__text -->
                          <!--<h3 class="team-details__subtitle">Certificate</h3>--><!-- /.team-details__subtitle -->
                          <!--<ul class="list-unstyled team-details__certificate-list">
                              <li>
                                  <img src="/assets/images/certificate-1-1.png" alt="">
                              </li>
                              <li>
                                  <img src="/assets/images/certificate-1-2.png" alt="">
                              </li>
                          </ul--><!-- /.list-unstyled -->

                          <!--<div class="progress-one__wrap">
                              <div class="progress-one__single">
                                  <div class="progress-one__top">
                                      <h3 class="progress-one__title">English</h3>--><!-- /.progress-one__title -->
                                      <!--<h3 class="progress-one__percent"><span class="counter">98</span>--><!-- /.counter --><!--%
                                      </h3>--><!-- /.progress-one__percent -->
                                  <!--</div>--><!-- /.progress-one__top -->
                                  <!--<div class="progress-one__bar">
                                      <span style="width: 98%;" class="wow slideInLeft"></span>
                                  </div>--><!-- /.progress-one__bar -->
                              <!--</div>--><!-- /.progress-one__single -->
                              <!--<div class="progress-one__single">
                                  <div class="progress-one__top">
                                      <h3 class="progress-one__title">French</h3>--><!-- /.progress-one__title -->
                                      <!--<h3 class="progress-one__percent"><span class="counter">64</span>--><!-- /.counter --><!--%
                                      </h3>--><!-- /.progress-one__percent -->
                                  <!--</div>--><!-- /.progress-one__top -->
                                  <!--<div class="progress-one__bar">
                                      <span style="width: 64%;" class="wow slideInLeft"></span>
                                  </div>--><!-- /.progress-one__bar -->
                              <!--</div>--><!-- /.progress-one__single -->
                              <!--<div class="progress-one__single">
                                  <div class="progress-one__top">
                                      <h3 class="progress-one__title">Spanish</h3>--><!-- /.progress-one__title -->
                                      <!--<h3 class="progress-one__percent"><span class="counter">34</span></h3>--><!-- /.progress-one__percent -->
                                  <!--</div>--><!-- /.progress-one__top -->
                                  <!--<div class="progress-one__bar">
                                      <span style="width: 34%;" class="wow slideInLeft"></span>
                                  </div>--><!-- /.progress-one__bar -->
                              <!--</div>--><!-- /.progress-one__single -->
                          <!--</div>--><!-- /.progress-one__wrap -->
                      </div><!-- /.team-details__content -->
                  </div><!-- /.col-lg-6 -->
                  <div class="col-lg-6">
                      <div class="team-one__single">
                          <div class="team-one__image">
                              <img src="/assets/images/team-d-1.jpg" alt="">
                          </div><!-- /.team-one__image -->
                          <div class="team-one__content">
                              <h2 class="team-one__name"><a href="team-details.html">{{teacher.fullNameEng}}</a></h2>
                              <!-- /.team-one__name -->
                              <p class="team-one__designation">{{teacher.professionEng}}</p><!-- /.team-one__designation -->

                          </div><!-- /.team-one__content -->
                          <div class="team-one__social">
                              <a :href="teacher.link" target="_blank"><i class="fab fa-linkedin"></i></a>
                          </div><!-- /.team-one__social -->
                      </div><!-- /.team-one__single -->
                  </div><!-- /.col-lg-6 -->
              </div><!-- /.row -->
          </div><!-- /.container -->
      </section><!-- /.team-details -->
      <section class="course-one__top-title thm-gray-bg" v-if="curriculums.length">
          <div class="container">
              <div class="block-title mb-0">
                  <h2 class="block-title__title">Courses i am <br>
                      offering</h2><!-- /.block-title__title -->
              </div><!-- /.block-title -->
          </div><!-- /.container -->
      </section><!-- /.course-one__top-title -->

      <section class="course-one course-one__teacher-details">
          <div class="container">
              <div class="row">
                  <div class="col-lg-4" v-for="curriculum in curriculums" :key="curriculum.id">
                      <div class="course-one__single">
                          <div class="course-one__image">
                              <img src="/assets/images/course-1-1.jpg" alt="">
                              <i class="far fa-heart"></i><!-- /.far fa-heart -->
                          </div><!-- /.course-one__image -->
                          <div class="course-one__content">
                            <a href="#" class="course-one__category">{{curriculum.categoryEng}}</a><!-- /.course-one__category -->
                            <div class="course-one__admin">
                              <img src="/assets/images/team-1-1.jpg" alt="">
                              by <a href="teacher-details.html">{{translations.CatalystAcademyText}}</a>
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
                            <nuxt-link :to="`/curriculums/${curriculum.id}`" class="course-one__link">
                              {{translations.SeePreview}}
                            </nuxt-link>
                          </div><!-- /.course-one__content -->
                      </div><!-- /.course-one__single -->
                  </div><!-- /.col-lg-4 -->
                 
              </div><!-- /.course-one__carousel -->
          </div><!-- /.container -->
      </section>
    </div>
</template>

<script>
  export default {
    name: "TeacherDetails",
    async fetch() {
      const teacherId = this.$route.params.id; // Get news ID from route parameters
      try {
        const response = await this.$axios.get(`/api/TeacherDetails/${teacherId}`);
        this.teacher = response.data;

        const curriculumResponse = await this.$axios.get('/api/Curriculums');
        this.curriculums = curriculumResponse.data;
      } catch (error) {
        // Handle errors
      }
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    data() {
      return {
        teacher: {},
        curriculums: []
      };
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    },
  };
</script>

<style scoped>

</style>
