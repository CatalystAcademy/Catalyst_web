<template>
    <div>
      <footer class="site-footer">
                  <div class="site-footer__upper">
                      <div class="container">
                          <div class="row">
                              <div class="col-xl-3 col-lg-6 col-sm-12">
                                  <div class="footer-widget footer-widget__contact" v-if="latestCurriculums.length">
                                    <h2 class="footer-widget__title">{{translations.OurLatestCurriculumsText}}</h2><!-- /.footer-widget__title -->
                                      <ul class="list-unstyled footer-widget__course-list" v-for="curriculum in latestCurriculums" :key="curriculum.id">
                                          <li class="mb-4">
                                              <h2><nuxt-link :to="`/curriculums/${curriculum.id}`">{{curriculum.titleEng}}</nuxt-link></h2>
                                              <p>{{curriculum.categoryEng}}</p>
                                          </li>
                                      </ul><!-- /.footer-widget__course-list -->
                                  </div><!-- /.footer-widget -->
                              </div><!-- /.col-lg-3 -->
                              <div class="col-xl-3 col-lg-6 col-sm-12">
                                  <div class="footer-widget footer-widget__link">
                                    <h2 class="footer-widget__title">{{translations.Explore}}</h2><!-- /.footer-widget__title -->
                                      <div class="footer-widget__link-wrap">
                                          <ul class="list-unstyled footer-widget__link-list">
                                              <li><a href="/about">{{translations.About}}</a></li>
                                              <li><a href="/teachers">{{translations.Instructors}}</a></li>
                                              <li><a href="/news">{{translations.OurNewsText}}</a></li>
                                              <li><a href="/apply">{{translations.JoinUsText}}</a></li>
                                              <li><a href="/contact">{{translations.Contact}}</a></li>
                                          </ul><!-- /.footer-widget__link-list -->
<!--                                          <ul class="list-unstyled footer-widget__link-list">
                                          </ul>-->
                                            <!-- /.footer-widget__link-list -->
                                      </div><!-- /.footer-widget__link-wrap -->
                                  </div><!-- /.footer-widget -->
                              </div><!-- /.col-lg-3 -->
                              <div class="col-xl-3 col-lg-6 col-sm-12">
                                  <div class="footer-widget footer-widget__gallery">
                                    <h2 class="footer-widget__title">{{translations.Gallery}}</h2><!-- /.footer-widget__title -->
                                      <ul class="list-unstyled footer-widget__gallery-list">
                                          <li><img src="/assets/images/custom/about_ca_1_cut_66.jpg" alt=""></li>
                                          <li><img src="/assets/images/custom/about_us_cut_66.jpg" alt=""></li>
                                          <li><img src="/assets/images/custom/team_cut_66.jpg" alt=""></li>
<!--                                          <li><a href="#"><img src="/assets/images/footer-1-4.png" alt=""></a></li>
                                          <li><a href="#"><img src="/assets/images/footer-1-5.png" alt=""></a></li>
                                          <li><a href="#"><img src="/assets/images/footer-1-6.png" alt=""></a></li>-->
                                      </ul><!-- /.footer-widget__gallery -->
                                  </div><!-- /.footer-widget -->
                              </div><!-- /.col-lg-3 -->
                              <div class="col-xl-3 col-lg-6 col-sm-12">
                                  <div class="footer-widget footer-widget__about">
                                    <h2 class="footer-widget__title">{{translations.RequestInfoModalHeaderText}}</h2><!-- /.footer-widget__title -->
                                      <p class="footer-widget__text">
                                        {{translations.FooterCAText}}
                                      </p><!-- /.footer-widget__text -->
                                      <div class="footer-widget__btn-block">
                                        <!--<a href="#" class="thm-btn">Contact</a>--><!-- /.thm-btn -->

                                        <button @click="openModal" class="thm-btn">{{translations.RequestMoreInfoBtnText}}</button>
                                        <RequestInfoModal />
                                        <!-- /.thm-btn -->
                                      </div><!-- /.footer-widget__btn-block -->
                                  </div><!-- /.footer-widget -->
                              </div><!-- /.col-lg-3 -->
                          </div><!-- /.row -->
                      </div><!-- /.container -->
                  </div><!-- /.site-footer__upper -->
                  <div class="site-footer__bottom">
                      <div class="container">
                          <p class="site-footer__copy">&copy; Copyright 2024 by <a href="#">Catalyst Academy</a></p>
                          <div class="site-footer__social">
                            <a href="#" data-target="html" class="scroll-to-target site-footer__scroll-top"><i class="kipso-icon-top-arrow"></i></a>
                            <a href="https://www.facebook.com/catalystacademyarmenia?mibextid=ZbWKwL" target="_blank"><i class="fab fa-facebook-square"></i></a>
                            <a href="https://www.instagram.com/catalystsacademy?igsh=MTRwOWhuOHFtMzRpZg==" target="_blank"><i class="fab fa-instagram"></i></a>
                            <a href="https://www.linkedin.com/company/catalystsacademy/" target="_blank"><i class="fab fa-linkedin"></i></a>
                          </div><!-- /.site-footer__social -->
                          <!-- /.site-footer__copy -->
                      </div><!-- /.container -->
                  </div><!-- /.site-footer__bottom -->
              </footer>
      <div class="search-popup">
              <div class="search-popup__overlay custom-cursor__overlay">
                  <div class="cursor"></div>
                  <div class="cursor-follower"></div>
              </div><!-- /.search-popup__overlay -->
              <div class="search-popup__inner">
                  <form action="#" class="search-popup__form">
                      <input type="text" name="search" placeholder="Type here to Search....">
                      <button type="submit"><i class="kipso-icon-magnifying-glass"></i></button>
                  </form>
              </div><!-- /.search-popup__inner -->
          </div>
    </div>
</template>

<script>
  import RequestInfoModal from '~/components/RequestInfoModal.vue';
  import https from 'https';

    export default {
    name: "Footer",
    components: {
      RequestInfoModal,
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    methods: {
      openModal() {
        this.$store.commit('setRequestInfoModalState', true);
      },
      closeModal() {
        this.$store.commit('setRequestInfoModalState', false);
      },
    },
    data() {
      return {
        latestCurriculums: [],
      }
    },
    async fetch() { // Use fetch for component-level data fetching
      try {
        const response = await this.$axios.get('/api/Curriculums/Other');
        this.latestCurriculums = response.data;

      } catch (error) {
        console.error('Error fetching teachers or welcome message:', error);
        this.error = true;
      }
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
    }
</script>

<style scoped>
  .footer-widget {
    padding-top: 120px;
    padding-bottom: 40px;
  }
  .footer-widget__link {
    padding-right: 0px;
    position: relative;
    left: 25px;
  }
</style>
