<template>
  <section class="about-one ">
    <img src="/assets/images/circle-stripe.png" class="about-one__circle" alt="">
    <div class="container text-center">
      <div class="block-title text-center">
        <h2 class="block-title__title">
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

      </p><!-- /.about-one__text -->
        <video width="320" height="240" controls>
          <source src="/assets/videos/CA_video.mp4" type="video/mp4">
          Your browser does not support the video tag.
        </video>

      <a href="#" class="thm-btn about-one__btn">Start Learning Now</a><!-- /.thm-btn -->
    </div><!-- /.container -->
  </section>
</template>

<script>
  export default {
    name: "Values",
/*    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    }*/
  }
</script>

<style scoped>

</style>
