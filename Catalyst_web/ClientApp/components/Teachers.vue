<template>
  <section class="team-one team-page">
    <div class="container">
      <div class="row" v-if="teachers.length">
        <div class="col-xl-3 col-lg-6 col-md-6 col-sm-12" v-for="teacher in teachers" :key="teacher.id">
          <div class="team-one__single">
            <div class="team-one__image">
              <img src="/assets/images/team-1-1.jpg" alt="">
            </div><!-- /.team-one__image -->
            <div class="team-one__content">
              <h2 class="team-one__name"><nuxt-link :to="`teachers/${teacher.id}`">{{teacher.fullNameEng}}</nuxt-link></h2>
              <!-- /.team-one__name -->
              <p class="team-one__designation">Teacher</p><!-- /.team-one__designation -->
<!--              <p class="team-one__text">There are many varia of passages of lorem.</p>
-->              <!-- /.team-one__text -->
            </div><!-- /.team-one__content -->
            <div class="team-one__social">
              <a href="#"><i class="fab fa-linkedin"></i></a>
            </div><!-- /.team-one__social -->
          </div><!-- /.team-one__single -->
        </div><!-- /.col-lg-3 -->
      </div><!-- /.row -->


      <div class="row custom-margin" id="teacher-register-section">
        <div class="col-lg-6">
          <div class="become-teacher__content">
            <h2 class="become-teacher__title">{{translations.TeachingBenefits}}</h2><!-- /.become-teacher__title -->
            <p class="become-teacher__text">
              {{translations.BecomeInstructorDesc}}
            </p><!-- /.become-teacher__text -->
            <h2 class="become-teacher__subtitle">
              {{translations.WhyTeachCAText}}
              </h2><!-- /.become-teacher__subtitle -->
            <p class="become-teacher__text">
              {{translations.WhyTeachCADesc}}
            </p><!-- /.become-teacher__text -->
            <h2 class="become-teacher__subtitle">{{translations.QualificationsText}}</h2><!-- /.become-teacher__subtitle -->
            <p class="become-teacher__text">
              {{translations.QualificationsDesc}}
            </p><!-- /.become-teacher__text -->
          </div><!-- /.become-teacher__content -->
        </div><!-- /.col-lg-6 -->
        <div class="col-lg-6">
          <div class="become-teacher__form">
            <div class="become-teacher__form-top">
              <h2 class="become-teacher__form-title">
                {{translations.BecomeInstructorText}}
            </h2><!-- /.become-teacher__form-title -->
            </div><!-- /.become-teacher__top -->
            <form @submit.prevent="register" action="/assets/inc/sendemail.php" class="become-teacher__form-content contact-form-validated">
              <input v-model="registrationData.fullName" type="text" placeholder="Your full Name" name="fullName">
              <input v-model="registrationData.email" type="text" placeholder="Email Address" name="email">
              <client-only>
                <b-form-select v-model="selectedCurriculum" :options="curriculumOptions" class="mb-3">
                  <b-form-select-option :value="null" disabled>-- Please select an option --</b-form-select-option>
                </b-form-select>
              </client-only>
          <input v-model="registrationData.phoneNumber" type="text" placeholder="Phone Number" name="phone">
          <input v-model="registrationData.message" type="text" placeholder="Comment" name="message">
          <button type="submit" class="thm-btn become-teacher__form-btn">Apply For It</button>
          </form><!-- /.become-teacher__form-content -->
          <div class="result text-center"></div><!-- /.result -->
        </div><!-- /.become-teacher__form -->
        </div><!-- /.col-lg-6 -->
      </div><!-- /.row -->
    </div><!-- /.container -->
  </section>
</template>


<script>
  import https from 'https';

  export default {
    name: 'Instructors',
    data() {
      return {
        teachers: [],
        error: false,
        registrationData: { fullName: '', email: '', curriculumId: null, phoneNumber: '', message: '' },
        curriculumOptions: [],
        selectedCurriculum: null,
      };
    },
    computed: {
      translations() {
        return this.$store.state.translations;
      },
    },
    async fetch() { // Use fetch for component-level data fetching
      try {
        const response = await this.$axios.get('/api/Teachers');
        this.teachers = response.data;

      } catch (error) {
        console.error('Error fetching teachers or welcome message:', error);
        this.error = true;
      }
    },
    methods: {
      async fetchCurriculums() {
        try {
          const response = await this.$axios.get('/api/Curriculums');
          this.curriculumOptions = response.data.map(curriculum => ({
            value: curriculum.id,
            text: curriculum.titleEng,
          }));
        } catch (error) {
          console.error('Error fetching Curriculums:', error);
          this.error = true; // Consider displaying an error message to the user
        }
      },
      async register() {
        this.registrationData.curriculumId = this.selectedCurriculum;
        
        await this.$axios.post('/api/BecomeTeacher/Register', this.registrationData)
            .then(response => {
              console.log(response);
              // Show success or error toast based on response
              if (response.status === 200) {
                this.$toasted.success('Registration successful!');
                setTimeout(() => {
                  window.location = '/teachers';
                }, 3000);
              } else {
                this.$toasted.error('An unexpected error occurred. Please contact support.'); // Assuming a 'message' property in error response
              }
            })
            .catch(error => {
              // Handle generic errors
              this.$toasted.error('An error occurred during registration. Please try again.');
            });
        } 
    },
    async created() {
      await this.fetchCurriculums();
      await this.$store.dispatch('fetchTranslations');
      // Optional: Set up HTTPS agent for self-signed certificates (if needed)
      if (process.env.NODE_ENV === 'development') {
        this.$axios.defaults.httpsAgent = new https.Agent({ rejectUnauthorized: false });
      }
    },
  };
</script>

<style scoped>
  .custom-margin {
      margin-top: 30px
  }
</style>
