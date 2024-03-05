<template>
  <section class="brand-two ">
      <div class="container">
          <div class="block-title">
            <h2 class="block-title__title">{{translations.OurPartners}}</h2><!-- /.block-title__title -->
          </div><!-- /.block-title -->
          <div class="brand-one__carousel owl-carousel owl-theme">
              <div class="item">
                  <img src="/assets/images/custom/aua.png" alt="">
              </div><!-- /.item -->
              <div class="item">
                  <img src="/assets/images/custom/Eiu_logo.jpg" alt="">
              </div><!-- /.item -->
              <div class="item">
                  <img src="/assets/images/custom/orion.jpg" alt="">
              </div><!-- /.item -->
              <div class="item">
                  <img src="/assets/images/custom/evrasia_new.png" alt="">
              </div><!-- /.item -->
              <div class="item">
                  <img src="/assets/images/custom/gbridge.png" alt="">
              </div><!-- /.item -->
              <div class="item">
                  <img src="/assets/images/custom/log_partner.png" alt="">
              </div><!-- /.item -->
              <div class="item">
                  <img src="/assets/images/custom/ohanyan.png" alt="">
              </div><!-- /.item -->
              <div class="item">
                  <img src="/assets/images/custom/poqrikishkhan.png" alt="">
              </div><!-- /.item -->
              <div class="item">
                  <img src="/assets/images/custom/startup.png" alt="">
              </div><!-- /.item -->
          </div><!-- /.brand-one__carousel owl-carousel owl-theme -->
      </div><!-- /.container -->
  </section>
</template>

<script>
  export default {
    name: "ClientsLogoTwo",
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    async created() {
      await this.$store.dispatch('fetchTranslations');
    },
  };
</script>

<style scoped>

</style>
