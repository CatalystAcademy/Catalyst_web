<template>
  <section class="about-one ">
    <img src="/assets/images/circle-stripe.png" class="about-one__circle" alt="">
    <div class="container text-center">
      <div class="block-title text-center">
        <h2 class="block-title__title">
          {{translations.BeChampionOfChange}}
        </h2><!-- /.block-title__title -->
      </div><!-- /.block-title -->
      <div class="about-one__img">
        <div class="row">
          <div class="col-lg-6">
            <img src="/assets/images/about-2-1.jpg" alt="">
          </div><!-- /.col-lg-6 -->
          <div class="col-lg-6">
            <img src="/assets/images/about-2-2.jpg" alt="">
          </div><!-- /.col-lg-6 -->
        </div><!-- /.row -->
        <div class="about-one__review">
          <p class="about-one__review-count counter">88750</p><!-- /.about-one__review-count -->
          <div class="about-one__review-stars">
            <i class="fas fa-star"></i><!-- /.fa fa-star -->
            <i class="fas fa-star"></i><!-- /.fa fa-star -->
            <i class="fas fa-star"></i><!-- /.fa fa-star -->
            <i class="fas fa-star"></i><!-- /.fa fa-star -->
            <i class="fas fa-star"></i><!-- /.fa fa-star -->
          </div><!-- /.about-one__stars -->
          <p class="about-one__review-text">students loved us</p><!-- /.about-one__review-text -->
        </div><!-- /.about-one__review -->
      </div><!-- /.about-one__img -->
      <p class="about-one__text">
        <h6 class="mb-3 block-title__title">{{translations.OurVision}} </h6>
      <ul>
        <li>{{translations.VisionOne}}</li>
        <li>{{translations.VisionTwo}}</li>
      </ul>
        
      </p><!-- /.about-one__text -->
      <p class="about-one__text">
        <h6 class="mb-3 block-title__title">{{translations.OurMission}} </h6>
        <ul>
          <li>{{translations.MissionOne}}</li>
          <li>{{translations.MissionTwo}}</li>
        </ul>
      </p>
      <a href="#" class="thm-btn about-one__btn">{{translations.StartLearningNowBtn}}</a><!-- /.thm-btn -->
    </div><!-- /.container -->
  </section>
</template>

<script>export default {
    name: "MissionandVision",
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    }
  }
  </script>

<style scoped>
</style>
